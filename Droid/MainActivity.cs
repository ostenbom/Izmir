﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Xamarin;

namespace Izmir.Droid
{
	[Activity (Label = "İzmir 2015", Icon = "@drawable/icon", Theme = "@style/Theme.Izmir", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			ImageCircleRenderer.Init ();
			Insights.Initialize("deae3245b81c8bfb26a7a701fe6e0191180ad3f7", this);
			LoadApplication (new App ());

		}
	}
}

