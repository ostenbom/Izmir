using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using Izmir;
using Izmir.iOS;

[assembly: ExportRenderer (typeof (BaseUrlWebView), typeof (BaseUrlWebViewRenderer))]

namespace Izmir.iOS
{
	public class BaseUrlWebViewRenderer : WebViewRenderer 
	{
		public override void LoadHtmlString (string s, NSUrl BaseUrl) 
		{
			if (BaseUrl == null) {
				BaseUrl = new NSUrl (NSBundle.MainBundle.BundlePath, true);
			}
			base.LoadHtmlString (s, BaseUrl);
		}
	}
}


