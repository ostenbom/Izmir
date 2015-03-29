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

			pages.Add (new ContentPage { Content = new StackLayout {
					Children = {
						new Label { Text = "HomePage!" }

					}
				}
			});

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


