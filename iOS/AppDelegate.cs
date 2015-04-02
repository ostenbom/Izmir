using System;
using System.Collections.Generic;
using System.Linq;
using ImageCircle.Forms.Plugin.iOS;
using Foundation;
using UIKit;
using Xamarin;

namespace Izmir.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
			ImageCircleRenderer.Init ();
			Insights.Initialize("deae3245b81c8bfb26a7a701fe6e0191180ad3f7");

			UINavigationBar.Appearance.BackgroundColor = UIColor.FromRGBA(0, 0, 0, 0);
			UINavigationBar.Appearance.TintColor = UIColor.White;
			UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB (33, 144, 166);
			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
				{
					TextColor = UIColor.White
				});

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

