using System;

using Xamarin.Forms;

namespace Izmir
{
	public class Turkish : ContentPage
	{
		public Turkish ()
		{
			Title = "Turkish Dictionary";
			var browser = new BaseUrlWebView () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			var source = new HtmlWebViewSource ();

			if (Device.OS != TargetPlatform.iOS) {
				// the BaseUrlWebViewRenderer does this for iOS, until bug is fixed
				source.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			}

			string url = source.BaseUrl + "turkish.html";

			browser.Source = url;

			Content = browser;
		}
	}
}


