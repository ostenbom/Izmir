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
			
			int i = 1;
			var viewModel = new PostsViewModel ();
			await viewModel.GetPosts ();
			foreach (Post p in viewModel.Posts) {
				pages.Add (new ContentPage { Content = new StackLayout {
						Children = {
							new Label { Text = p.title }

						}
					}
				});
				this.Children.Add (pages [i]);
				i++;
			};
			var postl = new PostsList (viewModel.Posts);
			pages.Add ( new ContentPage {
				Content = new ScrollView {
					Content = postl
				}	
			});
			this.Children.Add (pages[6]);

		}
	}
}


