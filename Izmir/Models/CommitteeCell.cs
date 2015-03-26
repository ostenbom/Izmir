using System;
using Xamarin.Forms;
using ImageCircle.Forms.Plugin.Abstractions;

namespace Izmir
{
	public class CommitteeCell:ViewCell
	{
		public CommitteeCell ()
		{
			var chairProfileImage = new CircleImage {
				BorderColor = Color.Aqua,
				BorderThickness = 2,
				HeightRequest = 50,
				WidthRequest = 50,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
			chairProfileImage.SetBinding (Image.SourceProperty, "ChairPic");

			var nameLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black
			};
			nameLabel.SetBinding (Label.TextProperty, "ChairName");

			var journoLabel = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 12,
				TextColor = Color.FromHex ("#666")
			};
			journoLabel.SetBinding (Label.TextProperty, "JournoName");

			var statusLayout = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				Children = { journoLabel }
			};

			var comDetailsLayout = new StackLayout {
				Padding = new Thickness (10, 0, 0, 0),
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { nameLabel, statusLayout }
			};

			var cellLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (10, 5, 10, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { chairProfileImage, comDetailsLayout}
			};

			this.View = cellLayout;
		}
	}
}


