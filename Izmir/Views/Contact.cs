using System;

using Xamarin.Forms;

namespace Izmir
{
	public class Contact : ContentPage
	{
		public Contact ()
		{
			Title = "Contact";
			double fontsize = Device.GetNamedSize (NamedSize.Large, typeof(Label));
			var icon = new Image { HeightRequest = 120 };
			icon.Source = "c.png";
			var hot = new Label {
				Text = "Session Hotline",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var emerg = new Label {
				Text = "For emergencies",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var hotlab = new Label {
				Text = "+90 (535) 262 73 63",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var hotbtn = new Button {
				Text = "Call Hotline",
				VerticalOptions = LayoutOptions.Center
			};
			hotbtn.Clicked += (sender, e) => Device.OpenUri (new Uri ("tel:+905352627363"));

			var to = new Label {
				Text = "Teachers' Organiser",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var tod = new Label {
				Text = "Enescan Karaer",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var ton = new Label {
				Text = "+90 (539) 261 6812",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var tob = new Button {
				Text = "Call Teachers Organiser",
				VerticalOptions = LayoutOptions.Center
			};
			tob.Clicked += (sender, e) => Device.OpenUri (new Uri ("tel:+905392616812"));

			var ho = new Label {
				Text = "Head Organiser",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var hod = new Label {
				Text = "Öykü Talı",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var hon = new Label {
				Text = "+90 (532) 512 5964",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var hob = new Button {
				Text = "Call Öykü",
				VerticalOptions = LayoutOptions.Center	
			};
			hob.Clicked += (sender, e) => Device.OpenUri (new Uri ("tel:+905325125964"));

			var iop = new Label {
				Text = "-",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var io = new Label {
				Text = "International Office of the EYP",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var iod = new Label {
				Text = "All general inquiries and questions:",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var ion = new Label {
				Text = "+49 (0)30 97 00 50 95",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var iob = new Button {
				Text = "Call The Office",
				VerticalOptions = LayoutOptions.Center	
			};
			iob.Clicked += (sender, e) => Device.OpenUri (new Uri ("tel:+493097005095"));

			var stefan = new Label {
				Text = "Stefan Vandenhende",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				FontSize = fontsize
			};
			var stefand = new Label {
				Text = "Project Manager - International Office of the EYP ",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var stefann = new Label {
				Text = "+49 (0)30 97 00 50 95",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center
			};
			var stefanb = new Button {
				Text = "Call Stefan",
				VerticalOptions = LayoutOptions.Center	
			};
			stefanb.Clicked += (sender, e) => Device.OpenUri (new Uri ("tel:+493097005095"));

			Content = new ScrollView { Content = new StackLayout { 
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Padding = new Thickness (0, 0, 0, 0),
					Children = {
						icon,
						hot,
						emerg,
						hotlab,
						hotbtn,
						to,
						tod,
						ton,
						tob,
						ho,
						hod,
						hon,
						hob,
						iop,
						io,
						iod,
						ion,
						iob,
						stefan,
						stefand,
						stefann,
						stefanb
					}
				}};
		}
	}
}


