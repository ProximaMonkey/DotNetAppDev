﻿using ExceptionAnalyzer.Utils;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using System;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionAnalyzer
{
    [ExportCodeFixProvider("GenericCatchBlockCodeFixProvider", LanguageNames.CSharp), Shared]
    public class GenericCatchBlockCodeFixProvider : CodeFixProvider
    {
        private const string FixText = "Change `catch` to `catch(Exception ex)";
        public override ImmutableArray<string> FixableDiagnosticIds =>  
            ImmutableArray.Create(GenericCatchBlockAnalyzer.DiagnosticId);

        public sealed override FixAllProvider GetFixAllProvider()
        {
            return WellKnownFixAllProviders.BatchFixer;
        }

        public override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

            var diagnostic = context.Diagnostics.First();
            var diagnosticSpan = diagnostic.Location.SourceSpan;
            var token = root.FindToken(diagnosticSpan.Start); // This is catch keyword.

            var catchBlock = token.Parent as CatchClauseSyntax;

            
            var newCatchClause = await CatchUtils.WitchExceptionDeclarationAsync(catchBlock, context.Document);
            var newRoot = root.ReplaceNode(catchBlock, newCatchClause);

            var codeAction = CodeAction.Create(FixText, ct => Task.FromResult(context.Document.WithSyntaxRoot(newRoot)));
            context.RegisterCodeFix(codeAction, diagnostic);
        }
    }

    internal static class CatchUtils
    {
        public static async Task<CatchClauseSyntax> WitchExceptionDeclarationAsync(
            CatchClauseSyntax catchBlock, Document document, string identifierName = "ex")
        {
            // Create a new block with a list that contains a throw statement.
            var throwStatement = SyntaxFactory.ThrowStatement();

            var root = await document.GetSyntaxRootAsync().ConfigureAwait(false);

            var semanticModel = await document.GetSemanticModelAsync().ConfigureAwait(false);
            var exceptionType = semanticModel.Compilation.GetTypeByMetadataName(typeof(Exception).FullName);

            // TODO: super naive pproach
            // Getting all using statements and looking for System there
            var usings =
                root.DescendantNodesAndSelf().OfType<NamespaceDeclarationSyntax>().SelectMany(nd => nd.Usings)
                .Union(
                    root.DescendantNodesAndSelf().OfType<CompilationUnitSyntax>().SelectMany(nd => nd.Usings)).ToArray();

            bool systemNamespaceAdded =
                usings.Any(x => x.As(y => y.Name as IdentifierNameSyntax)?.Identifier.ValueText == "System");

            TypeSyntax name = SyntaxFactory.QualifiedName(SyntaxFactory.IdentifierName(@"System"),
                SyntaxFactory.IdentifierName(@"Exception"));
            if (systemNamespaceAdded)
            {
                name = SyntaxFactory.IdentifierName(exceptionType.Name);
            }

            var newDeclaration = SyntaxFactory
                .CatchDeclaration(name, SyntaxFactory.Identifier(identifierName))
                .WithTrailingTrivia(catchBlock.CatchKeyword.TrailingTrivia);

            return 
                // Trailing Trivia moved to catch declaration. Removing it from CatchKeyword
                catchBlock.WithCatchKeyword(catchBlock.CatchKeyword.WithTrailingTrivia(SyntaxTriviaList.Empty))
                    .WithDeclaration(newDeclaration)
                    .WithAdditionalAnnotations(Formatter.Annotation);
        }
    }
}