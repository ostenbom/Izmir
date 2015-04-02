using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Izmir
{
	public interface IBaseUrl { string Get(); }

	// required temporarily for iOS, due to BaseUrl bug
	public class BaseUrlWebView : WebView { }

	public class App : Application
	{
		public App ()
		{

			var IzmirTabs = new TabbedPage ();
			IzmirTabs.Children.Add (new NavigationPage (new HomePage ()) {Title="Home", Icon = "h.png"});
			IzmirTabs.Children.Add (new NavigationPage (new CommitteesPage ()) {Title="Committees", Icon = "com.png"});
			IzmirTabs.Children.Add (new NavigationPage (new SchedulePage ()) {Title="Schedule", Icon = "cal.png"});
			IzmirTabs.Children.Add (new NavigationPage (new OtherPage ()) {Title="Other", Icon = "m.png"});

			MainPage = IzmirTabs;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

