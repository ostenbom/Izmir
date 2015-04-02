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

			string baseurl = source.BaseUrl;

			System.Diagnostics.Debug.WriteLine ("Base url is: {0}", baseurl);

			source.Html = @"<!DOCTYPE html>
<html>
<head>
    <link href=""default.css"" rel=""stylesheet"" type=""text/css"">

    <title></title>
</head>

<body class=""single"">
    <div id=""container"">
        <main class=""singlepage"" id=""main"" itemprop=""mainContentOfPage""
        itemscope itemtype=""http://schema.org/Blog"" role=""main"">
            <article class="""">
                <section class=""entry-content cf"">"+ com.Overview +" </section>\n            </article>\n        </main>\n    </div>\n</body>\n</html>";


			if (Device.OS != TargetPlatform.iOS) {
				// the BaseUrlWebViewRenderer does this for iOS, until bug is fixed
				source.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			}

			browser.Source = source;

			Content = browser;
		}
	}
}


