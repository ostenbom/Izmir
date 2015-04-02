using System;
using Xamarin.Forms;

namespace Izmir
{
	public class OtherPersonCell:ViewCell
	{
		public OtherPersonCell ()
		{
			var thumbnail = new Image {
				HeightRequest = 50,
				WidthRequest = 50,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
			thumbnail.SetBinding (Image.SourceProperty, "image");

			var titleLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black
			};
			titleLabel.SetBinding (Label.TextProperty, "name");

			var dateLabel = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 12,
				TextColor = Color.FromHex ("#666")
			};
			dateLabel.SetBinding (Label.TextProperty, "title");

			var statusLayout = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = { dateLabel }
			};

			var comDetailsLayout = new StackLayout {
				Padding = new Thickness (10, 0, 0, 0),
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { titleLabel, statusLayout }
			};

			var cellLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (10, 5, 10, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { thumbnail, comDetailsLayout}
			};

			this.View = cellLayout;
		}
	}
}

