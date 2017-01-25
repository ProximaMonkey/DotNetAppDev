﻿using FirstsStepsRUI.Models;
using ReactiveUI;
using System.Reactive.Linq;

namespace FirstsStepsRUI.ViewModels
{
   public class MenuOptionViewModel : ReactiveObject
   {
      public Menu Model { get; protected set; }
      public ReactiveCommand<Menu> SelectedOption { get; protected set; }

      public MenuOptionViewModel(Menu model)
      {
         Model = model;
         SelectedOption = ReactiveCommand.CreateAsyncObservable(e => Observable.Return(Model));
      }

      public override string ToString()
      {
         return Model.ToString();
      }
   }
}
