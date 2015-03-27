using System;
using Xamarin.Forms;
using Xamarin;
using System.Collections.Generic;

namespace Izmir
{
	public class HomePage : ContentPage
	{
		static PostsDatabase database;

		public static PostsDatabase Database {
			get { return database; }
		}

		ListView lv;
		Label l;

		public HomePage ()
		{
			Title = "Home";

			l = new Label { Text = "Posts", Font = Font.BoldSystemFontOfSize(NamedSize.Large) };

			var b = new Button { Text = "Get Posts" };
			b.Clicked += async (sender, e) => {
				var sv = new PostClient();
				var es = await sv.GetPostsAsync();
				Xamarin.Forms.Device.BeginInvokeOnMainThread( () => {
					l.Text = es.Length + " posts";
					lv.ItemsSource = es;
				});
				Insights.Track("postsdownloaded", new Dictionary<string, string> {{"amount","10 posts"}});
			};

			lv = new ListView ();
			lv.ItemTemplate = new DataTemplate(typeof(TextCell));
			lv.ItemTemplate.SetBinding(TextCell.TextProperty, "title");
			/* lv.ItemSelected += (sender, e) => {
				var eq = (Post)e.SelectedItem;
				DisplayAlert("Post info", eq.ToString(), "OK", null);
			}; */

			Content = new StackLayout {
				Padding = new Thickness (0, 20, 0, 0),
				Children = {
					l,
					b,
					lv
				}
			};
		}
	}
}


