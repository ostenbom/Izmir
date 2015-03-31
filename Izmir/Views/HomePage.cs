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

		public HomePage ()
		{
			Title = "Home";

			var myLabel = new Label () {
				Text = "Hello World",
				FontSize = 20,
				TextColor = Color.White,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};

			var myImage = new Image () {
				Source = FileImageSource.FromFile("cw1.jpg")
			};

			RelativeLayout layout = new RelativeLayout ();

			layout.Children.Add (myImage, 
				Constraint.Constant (0), 
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => { return parent.Width; }),
				Constraint.RelativeToParent ((parent) => { return parent.Height; }));

			layout.Children.Add (myLabel, 
				Constraint.Constant (0), 
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => { return parent.Width; }),
				Constraint.RelativeToParent ((parent) => { return parent.Height; }));

			pages.Add (new ContentPage { Content = new ScrollView () { Content = new StackLayout { Children = { new Label { Text = "Hello World" }, layout, new Label { Text = "Maybe something else" }}}} });

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
			var postl = new PostsList (viewModel.Posts);
			pages.Add ( new ContentPage {
				Content = new ScrollView {
					Content = postl
				}	
			});
			while (j < i) {
				this.Children.Add (pages [j]);
				j++;
			}

		}
	}
}


