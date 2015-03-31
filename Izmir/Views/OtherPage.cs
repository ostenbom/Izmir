using System;

using Xamarin.Forms;

namespace Izmir
{
	public class OtherPage : ContentPage
	{
		public OtherPage ()
		{
			Title = "Other Things";

			var contactpic = new Image ();

			contactpic.Source = "contact.jpg";

			var contacttap = new TapGestureRecognizer ();
			contacttap.Tapped += async (sender, e) => {
				var contactpage = new Contact();
				await Navigation.PushAsync(contactpage);
			};
			contactpic.GestureRecognizers.Add (contacttap);

			var aboutpic = new Image ();

			aboutpic.Source = "about.jpg";

			var abouttap = new TapGestureRecognizer ();
			abouttap.Tapped += async (sender, e) => {
				var aboutpage = new About();
				await Navigation.PushAsync(aboutpage);
			};
			aboutpic.GestureRecognizers.Add (abouttap);

			var sponsorspic = new Image ();

			sponsorspic.Source = "sponsors.jpg";

			var sponsorstap = new TapGestureRecognizer ();
			sponsorstap.Tapped += async (sender, e) => {
				var sponsorspage = new Sponsors();
				await Navigation.PushAsync(sponsorspage);
			};
			sponsorspic.GestureRecognizers.Add (sponsorstap);

			var turkishpic = new Image ();

			turkishpic.Source = "turkish.jpg";

			var turkishtap = new TapGestureRecognizer ();
			turkishtap.Tapped += async (sender, e) => {
				var turkishpage = new Turkish();
				await Navigation.PushAsync(turkishpage);
			};
			turkishpic.GestureRecognizers.Add (turkishtap);

			Content = new ScrollView { Content = new StackLayout { 
					Children = {
						contactpic,
						aboutpic,
						sponsorspic,
						turkishpic
					},
					Spacing = 0
				}
			};
		}
	}
}


