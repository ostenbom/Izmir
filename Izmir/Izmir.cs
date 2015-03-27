using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Izmir
{
	public class App : Application
	{
		
		public App ()
		{
			var database = new PostsDatabase ();
			var posts = database.GetPosts ();

			var IzmirTabs = new TabbedPage ();
			IzmirTabs.Children.Add (new NavigationPage (new HomePage ()) {Title="Home", Icon = "xaml.png"});
			IzmirTabs.Children.Add (new NavigationPage (new CommitteesPage ()) {Title="Committees", Icon = "xaml.png"});
			IzmirTabs.Children.Add (new NavigationPage (new SchedulePage ()) {Title="Schedule", Icon = "xaml.png"});
			IzmirTabs.Children.Add (new NavigationPage (new OtherPage ()) {Title="Other", Icon = "xaml.png"});

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

