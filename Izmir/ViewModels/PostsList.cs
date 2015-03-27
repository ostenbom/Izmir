using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Izmir
{
	public class PostsList : ListView
	{
		public PostsList (List<Post> posts)
		{
			var cell = new DataTemplate (typeof (ImageCell));

			cell.SetBinding (TextCell.TextProperty, "title");
			cell.SetBinding (TextCell.DetailProperty, "date");
			cell.SetBinding (ImageCell.ImageSourceProperty, "thumbnail");

			ItemTemplate = cell;
			ItemsSource = posts;
		}
	}
}

