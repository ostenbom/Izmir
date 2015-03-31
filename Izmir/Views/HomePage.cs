using System;
using Xamarin.Forms;
using Xamarin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Izmir
{
	public class HomePage : CarouselPage
	{
		List<ContentPage> pages = new List<ContentPage> ();

		readonly List<Day> days = new ScheduleData ();

		readonly DateTime izmirstart = new DateTime (2015, 04, 17);

		readonly DateTime izmirend = new DateTime (2015, 04, 25, 18, 30, 00);

		readonly DateTime izmirshowend = new DateTime (2015, 04, 27);

		Image feature = new Image () { Aspect = Aspect.AspectFill };

		readonly Label currentevent = new Label () { FontSize = 20, HorizontalOptions = LayoutOptions.Center };

		StackLayout layout = new StackLayout () {Spacing = 0};

		StackLayout postloadlayout = new StackLayout { Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.Center };

		StackLayout swipelayout = new StackLayout { Orientation = StackOrientation.Horizontal, Padding = new Thickness(10, 0, 10 ,0) };

		ActivityIndicator postsloading = new ActivityIndicator
		{
			Color = Device.OnPlatform(Color.Black, Color.Default, Color.Default),
			IsRunning = true,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};

		public HomePage ()
		{
			Title = "Home";

			var swipelabel = new Label () {
				Text = "Swipe to check out posts",
				FontSize = 18,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			var swipeimage = new Image () {
				Source = FileImageSource.FromFile("ar.jpg"),
				HeightRequest = 15
			};

			swipelayout.Children.Add (swipelabel);
			swipelayout.Children.Add (swipeimage);

			OnTimeUpdate();

			Device.StartTimer (TimeSpan.FromMinutes(5), OnTimeUpdate);

			StackLayout featurelayout = new StackLayout {
				Children = { feature, currentevent },
				Spacing = 10
			};

			Label postloadlabel = new Label {
				Text = "Loading posts..",
				VerticalOptions = LayoutOptions.Center
			};

			postloadlayout.Children.Add (postsloading);
			postloadlayout.Children.Add (postloadlabel);

			layout.Children.Add (featurelayout);

			layout.Children.Add (postloadlayout);

			layout.Children.Add (swipelayout);

			pages.Add (new ContentPage { Content = new ScrollView () { Content = layout} });

			this.Children.Add (pages [0]);

			Init ();
		}

		private async Task Init ()
		{
			
			int i = 2;
			int j = 1;
			var viewModel = new PostsViewModel ();
			await viewModel.GetPosts ();
			foreach (Post p in viewModel.Posts) {
				pages.Add (new PostView (p));
				i++;
			};
			var postl = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate(typeof(PostCell)),
				ItemsSource = viewModel.Posts,
				SeparatorColor = Color.FromHex("#ddd")
			};
			pages.Add ( new ContentPage {
				Content = new StackLayout {
					Children = {postl}
				}	
			});
			while (j < i) {
				this.Children.Add (pages [j]);
				j++;
			}

			postsloading.IsRunning = false;

			layout.Children.Remove (postloadlayout);

		}

		bool OnTimeUpdate() {
			DateTime mytime = new DateTime (2015, 04, 23, 23, 00, 00);
			DateTime now = DateTime.Now;
			DateTime today = DateTime.Today;

			if (now < izmirstart) {
				feature.Source = FileImageSource.FromFile("pre.jpg");
				int numdays = (izmirstart - now).Days;
				if (numdays == 1) {
					currentevent.Text = numdays + " day until Izmir IS!";
				} else {
					currentevent.Text = numdays + " days until Izmir IS!";
				}
			} else {
				if (now > izmirshowend) {
					feature.Source = FileImageSource.FromFile("post.jpg");
					int numdays = (now - izmirend).Days;
					if (numdays == 1) {
						currentevent.Text = numdays + " day since Izmir.";
					} else {
						currentevent.Text = numdays + " days since Izmir IS";
					}
				} else {
					foreach (Day d in days) {
						if (d.day.Date == today) {
							feature.Source = FileImageSource.FromFile(d.image);
							foreach (Event e in d.events) {
								if ((now > e.start) && (now < e.end))
								{
									currentevent.Text = "Currently: "+e.description;
								}
							};
						}
					};
				}
			}
			if (currentevent.Text == null) {
				currentevent.Text = "Currently in between Events!";
			}
			return true;
		}
	}
}


