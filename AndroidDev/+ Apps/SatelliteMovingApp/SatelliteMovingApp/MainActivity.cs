﻿using Android.App;
using Android.OS;

namespace SatelliteMovingApp
{
   [Activity(Label = "@string/AppName", MainLauncher = false, Icon = "@drawable/icon")]
   public class MainActivity : Activity
   {
      protected override void OnCreate(Bundle bundle)
      {
         base.OnCreate(bundle);

         // Set our view from the "main" layout resource
         // SetContentView (Resource.Layout.Main);
      }
   }
}