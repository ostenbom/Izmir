using System;
using Xamarin.Forms;
using System.Collections.Generic;
using ImageCircle.Forms.Plugin.Abstractions;

namespace Izmir
{
	public class CommitteePage : ContentPage
	{
		public CommitteePage (CommitteesItem com)
		{
			StackLayout layout = new StackLayout { Spacing = 0 };

			var chairProfileImage = new CircleImage {
				BorderColor = Color.Aqua,
				BorderThickness = 2,
				HeightRequest = 80,
				WidthRequest = 80,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Source = ImageSource.FromFile(com.ChairPic)
			};

			var chairnameLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black,
				Text = com.ChairName
			};

			var chairtitleLabel = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 12,
				TextColor = Color.FromHex ("#666"),
				Text = "Chair"
			};

			var chairquoteLabel = new Label () {
				FontSize = 12,
				TextColor = Color.FromHex ("#666"),
				Text = com.ChairQuote
			};

			var chairDetailsLayout = new StackLayout {
				Padding = new Thickness (10, 0, 0, 0),
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { chairnameLabel, chairtitleLabel, chairquoteLabel }
			};

			var chairLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (10, 5, 10, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { chairProfileImage, chairDetailsLayout}
			};

			var journoProfileImage = new CircleImage {
				BorderColor = Color.Aqua,
				BorderThickness = 2,
				HeightRequest = 80,
				WidthRequest = 80,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Source = ImageSource.FromFile(com.JournoPic)
			};

			var journonameLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black,
				Text = com.JournoName
			};

			var journoquoteLabel = new Label () {
				FontSize = 12,
				TextColor = Color.FromHex ("#666"),
				Text = com.JournoQuote
			};

			var journotitleLabel = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 12,
				TextColor = Color.FromHex ("#666"),
				Text = "Journalist"
			};

			var journoDetailsLayout = new StackLayout {
				Padding = new Thickness (10, 0, 0, 0),
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { journonameLabel, journotitleLabel, journoquoteLabel }
			};

			var journoLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (10, 5, 10, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { journoProfileImage, journoDetailsLayout}
			};

			var topicLabel = new Label {
				Text = com.Topic,
				FontAttributes = FontAttributes.Italic,
				TextColor = Color.FromHex("#666"),
				HorizontalOptions = LayoutOptions.Center
			};

			var topicLayout = new StackLayout {
				Children = { topicLabel },
				Spacing = 0,
				HorizontalOptions = LayoutOptions.Center,
				Padding = new Thickness (10, 5, 10, 5)
			};

			var comTable = new TableView {
				Intent = TableIntent.Menu,
				HasUnevenRows = true,
				Root = new TableRoot ("A committee!") {
					new TableSection ("People in " + com.Title) {
						new ViewCell {
							View = chairLayout,
							Height = 150
						},
						new ViewCell {
							View = journoLayout,
							Height = 150
						}
					},
					new TableSection ("Committee Topic:") {
						new ViewCell {
							View = topicLayout,
							Height = 150
						},
						new TextCell {
							Text = "Topic Overview"	
						}
					}
				}
			};

			var titleLabel = new Label () {
				Text = com.Title,
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Transparent,
				FontSize = 24
			};

			var iconImage = new Image () {
				Source = ImageSource.FromFile(com.Icon),
				Aspect = Aspect.AspectFill
			};

			RelativeLayout comlayout = new RelativeLayout () {
				HeightRequest = 130,
				VerticalOptions = LayoutOptions.Start
			};

			comlayout.Children.Add (iconImage,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => { return parent.Width; }),
				Constraint.RelativeToParent ((parent) => ( parent.Bounds.Height )));

			comlayout.Children.Add (titleLabel,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((parent) => { return parent.Width; }),
				Constraint.RelativeToParent ((parent) => ( parent.Bounds.Height )));


			ScrollView scroll = new ScrollView {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = new StackLayout {
					Children = {comlayout, comTable},
					Spacing = 0
				}
			};

			this.Content = scroll;

			Device.OnPlatform(iOS: () => {
				this.Padding = new Thickness(0, 20, 0, 0);
			});

		}
	}
}


