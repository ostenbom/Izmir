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
                <section class=""entry-content cf"">"+post.content+"</body></html>";
			if (Device.OS != TargetPlatform.iOS) {
				// the BaseUrlWebViewRenderer does this for iOS, until bug is fixed
				source.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			}
			browser.Source = source;

			this.Content = browser;
		}
	}
}

