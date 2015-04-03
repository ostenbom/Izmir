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
			Title = com.Title;

			Command navigateCommand = 
				new Command(async (obj) => 
					{
						var overviewpage = new OverviewPage(obj as CommitteesItem);
						await Navigation.PushAsync(overviewpage);
					});

			var people = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 18,
				TextColor = Color.FromHex ("#666"),
				Text = "People in "+com.Title
			};

			var chairProfileImage = new CircleImage {
				BorderColor = Color.FromRgb(33, 144, 166),
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
				Padding = new Thickness (0, 5, 0, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { chairProfileImage, chairDetailsLayout}
			};

			var journoProfileImage = new CircleImage {
				BorderColor = Color.FromRgb(33, 144, 166),
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
				Padding = new Thickness (0, 5, 0, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { journoProfileImage, journoDetailsLayout}
			};

			var topic = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 16,
				TextColor = Color.FromHex ("#666"),
				Text = "Committee Topic"
			};

			var topicLabel = new Label {
				Text = com.Topic,
				FontAttributes = FontAttributes.Italic,
				TextColor = Color.FromHex("#666"),
				HorizontalOptions = LayoutOptions.Center
			};

			var topicbtn = new Button {
				Text = "Topic Overview",
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Command = navigateCommand,
				CommandParameter = com
			};

			var iconImage = new Image () {
				Source = ImageSource.FromFile(com.Cover),
				Aspect = Aspect.AspectFill
			};


			ScrollView scroll = new ScrollView {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = new StackLayout {
					Children = {iconImage, new StackLayout {
							Children ={ topic, topicLabel, topicbtn, people , chairLayout, journoLayout },
							Padding = new Thickness(10, 10, 10, 0)
						}},
					Spacing = 0
				}
			};

			this.Content = scroll;

		}
	}
}


