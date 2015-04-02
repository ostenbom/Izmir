using System;

using Xamarin.Forms;

namespace Izmir
{
	public class ImagePage : ContentPage
	{
		public ImagePage (Flickr pic)
		{
			Title = pic.title;
			Content = new StackLayout { 
				Children = {
					new Image {
						Source = ImageSource.FromUri(new Uri(pic.url_l)),
						Aspect = Aspect.AspectFill
					}
				}
			};
		}
	}
}


