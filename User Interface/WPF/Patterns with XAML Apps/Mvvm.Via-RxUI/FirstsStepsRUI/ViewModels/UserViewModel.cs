﻿using System;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FirstsStepsRUI.Models;
using FirstsStepsRUI.Repositories;
using ReactiveUI;

namespace FirstsStepsRUI.ViewModels
{
   public class UserViewModel : ReactiveObject, IRoutableViewModel
   {
      private string _code;
      private UserGroup _group;
      private string _message;
      private User _model;

      public UserViewModel(IScreen screen, User user, IUserRepository userRepository)
      {
         HostScreen = screen;
         // Commands
         var canSubmit = this.WhenAny(e => e.Code, code => code.Value.IsValid());
         Submit = ReactiveCommand.CreateAsyncTask(canSubmit, _ => userRepository.Submit(Model));
         Submit.Subscribe(result => MessageBox.Show(result ? "Success" : "Failure"));
         // Observe on UI thread
         Submit.ThrownExceptions.ObserveOn(RxApp.MainThreadScheduler)
            .Select(ex => new UserError("It will fail again, try anyway?", ex.Message))
            .SelectMany(UserError.Throw)
            .Subscribe(resolution =>
            {
               if (resolution == RecoveryOptionResult.RetryOperation)
                  Submit.Execute(null);
            });
         // Model subscription
         this.WhenAnyValue(e => e.Model).Where(e => e != null).Subscribe(model =>
         {
            Code = model.Code;
            Group = model.Group;
         });
         Model = user;
         // Properties subscriptions
         this.WhenAnyValue(e => e.Group).Subscribe(group => Model.Group = group);
         this.WhenAnyValue(e => e.Code).Subscribe(code => Model.Code = code);
         // Subscribe to error handle
         UserError.RegisterHandler(async error =>
         {
            // This shouldn't be a messagebox because is blocking the application, you must provide context and offer a resolution to the user not just showing "error"
            await Task.Delay(1).ConfigureAwait(true);
            var message = new StringBuilder();
            var hasRecoveryOptions = error.ErrorCauseOrResolution.IsValid();
            if (hasRecoveryOptions)
               message.AppendLine(error.ErrorCauseOrResolution);
            message.AppendLine(error.ErrorMessage);
            var result = MessageBox.Show(message.ToString(), "Alert!",
               hasRecoveryOptions ? MessageBoxButton.YesNo : MessageBoxButton.OK);

            return hasRecoveryOptions && result == MessageBoxResult.Yes
               ? RecoveryOptionResult.RetryOperation
               : RecoveryOptionResult.CancelOperation;
         });
      }

      public ReactiveCommand<bool> Submit { get; private set; }

      public User Model
      {
         get { return _model; }
         set { this.RaiseAndSetIfChanged(ref _model, value); }
      }

      public string Message
      {
         get { return _message; }
         set { this.RaiseAndSetIfChanged(ref _message, value); }
      }

      public string Code
      {
         get { return _code; }
         set { this.RaiseAndSetIfChanged(ref _code, value); }
      }

      public UserGroup Group
      {
         get { return _group; }
         set { this.RaiseAndSetIfChanged(ref _group, value); }
      }

      public string UrlPathSegment
      {
         get { return "User"; }
      }

      public IScreen HostScreen { get; protected set; }
   }
}