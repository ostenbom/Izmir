using System;
using Xamarin.Forms;
using Xamarin;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Izmir
{
	public class HomePage : CarouselPage
	{
		StackLayout layout = new StackLayout () {Spacing = 10};

		List<ContentPage> pages = new List<ContentPage> ();

		List<Day> days = new ScheduleData ();

		readonly DateTime izmirstart = new DateTime (2015, 04, 17);

		readonly DateTime izmirend = new DateTime (2015, 04, 25, 18, 30, 00);

		readonly DateTime izmirshowend = new DateTime (2015, 04, 27);

		PostsViewModel viewModel = new PostsViewModel ();

		Image feature = new Image () { Aspect = Aspect.AspectFill };

		readonly Label currentevent = new Label () { FontSize = 20, HorizontalOptions = LayoutOptions.Center };

		StackLayout postloadlayout = new StackLayout { Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.Center };

		StackLayout homepostlayout = new StackLayout { Padding = new Thickness(10, 0, 10 ,0), VerticalOptions = LayoutOptions.FillAndExpand };

		List<Post> homelist = new List<Post> ();

		ListView homelistview;

		ListView postl;

		bool firstsess = false;

		ObservableCollection<Post> vmop;

		Command navigateimageCommand;

		Grid imagegrid = new Grid {
			VerticalOptions = LayoutOptions.FillAndExpand,
			ColumnSpacing = 5,
			RowSpacing = 5,
			RowDefinitions = {
				new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },
				new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },
				new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },
				new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) }
			},
			ColumnDefinitions = {
				new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
			}
		};

		ActivityIndicator postsloading = new ActivityIndicator
		{
			Color = Device.OnPlatform(Color.Black, Color.Default, Color.Default),
			IsRunning = true,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};

		public HomePage ()
		{
			Title = "Home";

			navigateimageCommand = 
				new Command(async (obj) => 
					{
						var imagepage = new ImagePage(obj as Flickr);
						await Navigation.PushAsync(imagepage);
					});
			
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

			homelistview = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate(typeof(PostCell)),
				SeparatorColor = Color.FromHex("#ddd")
			};


			postloadlayout.Children.Add (postsloading);

			postloadlayout.Children.Add (postloadlabel);

			layout.Children.Add (featurelayout);

			layout.Children.Add (postloadlayout);

			layout.Children.Add (imagegrid);

			layout.Children.Add (homepostlayout);

			pages.Add (new ContentPage { Content = new ScrollView () { Content = layout} });

			this.Children.Add (pages [0]);

			ToolbarItems.Add(new ToolbarItem("Back", "undo.png", () =>
				{
					try {
					CurrentPage = this.Children[0];
					} catch (Exception e) {
						System.Diagnostics.Debug.WriteLine("Back Click: {0}", e);
					}
				}));

			Init ();

			/*Initimages ();*/

			homelistview.ItemSelected += (sender, e) => {
				var selectpost = (Post)e.SelectedItem;
				int pos = homelist.IndexOf(selectpost) + 1;
				CurrentPage = this.Children[pos]; 
				homelistview.SelectedItem = null; 
			};

		}

		private async Task Init ()
		{
			
			int i = 2;
			int j = 1;
			int k = 0;


			var client = new ImageClient ();
			await viewModel.GetPosts (5, 0);
			var vmposts = viewModel.Posts;
			vmop = viewModel.Oposts;
			if (viewModel.Posts.Count == 0) {
				vmposts = new SeedData ();
				vmop = new SeedOData ();
				firstsess = true;
			}
			while (i < 7) {
				pages.Add (new PostView (vmposts[k]));
				homelist.Add (vmposts[k]);
				k++;
				i++;
			}
			homelist.Add ( new Post {
				title = "All Posts",
				date = "",
				thumbnail = "plus.png"
			});

			homelistview.ItemsSource = homelist;

			homepostlayout.Children.Add (homelistview);

			postl = new InfiniteListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate(typeof(PostCell)),
				SeparatorColor = Color.FromHex("#ddd"),
				LoadMoreCommand = LoadPostsCommand,
				IsPullToRefreshEnabled = true,
				RefreshCommand = RefreshPostsCommand,
				IsRefreshing = IsBusy
			};
			postl.ItemsSource = vmop;
			pages.Add ( new ContentPage {
				Content = new StackLayout {
					Children = {postl}
				}	
			});
			while (j < i) {
				this.Children.Add (pages [j]);
				j++;
			}

			postl.ItemSelected += async (sender, e) => {
				var selectpost = (Post)e.SelectedItem;
				var postpage = new PostView(selectpost);
				await Navigation.PushAsync(postpage);
			};

			postsloading.IsRunning = false;

			layout.Children.Remove (postloadlayout);

			try {
				var images = await client.GetImages ();

				int p = 0;
				int c = 0;
				int r = -1;

				foreach (Flickr pic in images) {
					
					if ((p%4) == 0){
						r++;
					}

					c = (p%4);

					var flickpic = new Image {
						Aspect = Aspect.AspectFill,
						Source = ImageSource.FromUri(new Uri(pic.url_q))
					};

					var flickbtn = new Button () {
						Text = "",
						TextColor = Color.White,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						VerticalOptions = LayoutOptions.FillAndExpand,
						BackgroundColor = Color.Transparent,
						FontSize = 24,
						Command = navigateimageCommand,
						CommandParameter = pic
					};

					RelativeLayout comlayout = new RelativeLayout ();

					comlayout.Children.Add (flickpic,
						Constraint.Constant (0),
						Constraint.Constant (0),
						Constraint.RelativeToParent ((parent) => { return parent.Width; }),
						Constraint.RelativeToParent ((parent) => { return parent.Height; }));

					comlayout.Children.Add (flickbtn,
						Constraint.Constant (0),
						Constraint.Constant (0),
						Constraint.RelativeToParent ((parent) => { return parent.Width; }),
						Constraint.RelativeToParent ((parent) => { return parent.Height; }));

					try {
						imagegrid.Children.Add (comlayout, r, c);
					} catch (Exception e ) {
						System.Diagnostics.Debug.WriteLine ("Add image to grid: {0}", e);
					}

					p++;
				}
			} catch (Exception e) {
				System.Diagnostics.Debug.WriteLine("Get Images Home Fault: {0}", e);
			}



		}


		bool OnTimeUpdate() {
			DateTime mytime = new DateTime (2015, 04, 23, 13, 00, 00);
			DateTime now =  DateTime.Now;
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

		private Command loadPostsCommand;

		public Command LoadPostsCommand
		{
			get
			{
				return loadPostsCommand ??
					(loadPostsCommand = new Command(() => { ExecuteLoadPostsCommand(); }));
			}
		}

		public async Task ExecuteLoadPostsCommand () {
			int postcount = viewModel.PostCount;
			int count = viewModel._Oposts.Count;
			if (count < postcount){
				await viewModel.GetMorePosts (5,count);
			}
		}

		private bool isReloadBusy;
		public bool IsBusy
		{
			get { return isReloadBusy; }
			set 
			{
				if (isReloadBusy == value)
					return;

				isReloadBusy = value;
				OnPropertyChanged ("IsBusy");
			}
		}

		private Command refreshPostsCommand;

		public Command RefreshPostsCommand 
		{
			get 
			{ 
				return refreshPostsCommand ?? (refreshPostsCommand = new Command (ExecuteRefreshPostsCommand, ()=>
					{
						return !IsBusy;
					})); 
			}
		}

		private async void ExecuteRefreshPostsCommand ()
		{
			if (IsBusy)
				return;

			vmop.Clear ();
			await viewModel.GetPosts (5,0);

			if (vmop == null) {
				DisplayAlert ("Almost!", "Please connect to the internet before refreshing again", "Ok");
			}

			this.postl.IsRefreshing = false;

		}
	}
}


