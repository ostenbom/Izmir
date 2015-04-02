using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Izmir
{
	public class OtherPeopePage : ContentPage
	{
		public OtherPeopePage ()
		{
			List<OtherPerson> people = new OtherPeopleData ();
			var peoplelistview = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate(typeof(OtherPersonCell)),
				SeparatorColor = Color.FromHex("#ddd"),
				ItemsSource = people
			};
			Content = new StackLayout { 
				Children = {
					peoplelistview
				}
			};
			peoplelistview.ItemSelected += (sender, e) => {
				peoplelistview.SelectedItem = null; 
			};
		}
	}
}


