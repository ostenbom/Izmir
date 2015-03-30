using System;
using Xamarin.Forms;

namespace Izmir
{

	public class PostView : ContentPage
	{
		public PostView (Post post)
		{
			Title = post.title;
			var browser = new BaseUrlWebView () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			var source = new HtmlWebViewSource ();
			source.Html = @"<html><head>
<link rel=""stylesheet"" href=""default.css"">
</head><body>"+"<h1>"+post.title+"</h1>"+post.content+"</body></html>";
			if (Device.OS != TargetPlatform.iOS) {
				// the BaseUrlWebViewRenderer does this for iOS, until bug is fixed
				source.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			}
			browser.Source = source;

			this.Content = browser;
		}
	}
}

