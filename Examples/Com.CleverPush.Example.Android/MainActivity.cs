using Android.App;
using Android.Widget;
using Android.OS;
using Com.CleverPush.Example.Shared;
using System;

namespace Com.CleverPush.Example.Android
{
   [Activity(Label = "Com.CleverPush.Example.Android", MainLauncher = true, Icon = "@mipmap/icon")]
   public class MainActivity : Activity
   {
      protected override void OnCreate(Bundle savedInstanceState)
      {
         base.OnCreate(savedInstanceState);

         SetContentView(Resource.Layout.Main);

         SharedPush.Initialize();

		 Switch pushSwitch = FindViewById<Switch>(Resource.Id.pushSwitch);

		 pushSwitch.CheckedChange += delegate
         {
			 if (pushSwitch.Checked)
			 {
				 SharedPush.Subscribe();
			 } else
			 {
				 SharedPush.Unsubscribe();
			 }
         };
      }
   }
}
