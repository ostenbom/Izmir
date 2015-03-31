using System;

using Xamarin.Forms;

namespace Izmir
{
	public class Sponsors : ContentPage
	{
		public Sponsors ()
		{
			Title = "Sponsors";
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


