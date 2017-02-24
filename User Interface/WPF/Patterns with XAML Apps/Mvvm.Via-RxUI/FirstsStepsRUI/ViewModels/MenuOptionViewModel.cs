﻿using System.Reactive.Linq;
using FirstsStepsRUI.Models;
using ReactiveUI;

namespace FirstsStepsRUI.ViewModels
{
   public class MenuOptionViewModel : ReactiveObject
   {
      public MenuOptionViewModel(Menu model)
      {
         Model = model;
         SelectedOption = ReactiveCommand.CreateAsyncObservable(e => Observable.Return(Model));
      }

      public Menu Model { get; protected set; }
      public ReactiveCommand<Menu> SelectedOption { get; protected set; }

      public override string ToString()
      {
         return Model.ToString();
      }
   }
}