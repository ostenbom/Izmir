using System;

using Xamarin.Forms;

namespace Izmir
{
	public class About : ContentPage
	{
		public About ()
		{
			Title = "About";
			double fontsize = Device.GetNamedSize (NamedSize.Large, typeof(Label));
			var icon = new Image { HeightRequest = 120 };
			icon.Source = "i.png";
			var pres = new Label {
				Text = "President",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var ogulcan = new Label {
				Text = "Oğulcan Torun",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var ho = new Label {
				Text = "Head Organiser",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var oyku = new Label {
				Text = "Öykü Talı",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var editors = new Label {
				Text = "Editors",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var seb = new Label {
				Text = "Sebastian Hojas",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var me = new Label {
				Text = "Oliver Stenbom",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var app = new Label {
				Text = "App",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var by = new Label {
				Text = "App made by Oliver Stenbom for the 78th International Session of the European Youth Parliament in Izmir.",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			Content = new ScrollView { Content = new StackLayout { 
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Padding = new Thickness (30, 0, 30, 0),
				Children = {
					icon,
					ho,
					oyku,
					pres,
					ogulcan,
					editors,
					seb,
					me,
					app,
					by
				}
				}};
		}
	}
}


