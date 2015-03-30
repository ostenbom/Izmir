using System;

using Xamarin.Forms;

namespace Izmir
{
	

	public class OverviewPage : ContentPage
	{
		public OverviewPage (CommitteesItem com)
		{
			Title = com.Title + " Overview";
			var browser = new BaseUrlWebView () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			var source = new HtmlWebViewSource ();

			if (Device.OS != TargetPlatform.iOS) {
				// the BaseUrlWebViewRenderer does this for iOS, until bug is fixed
				source.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			}

			string url = source.BaseUrl + com.Overview;

			browser.Source = source.BaseUrl + com.Overview;

			Content = browser;
		}
	}
}


