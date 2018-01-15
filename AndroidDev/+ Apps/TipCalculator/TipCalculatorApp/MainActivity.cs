﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace TipCalculatorApp
{
   [Activity(Label = "TipCalculatorApp", MainLauncher = true)]
   public class MainActivity : AppCompatActivity
   {
      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);

         // Set our view from the "main" layout resource
         SetContentView(Resource.Layout.Main);
      }
   }
}