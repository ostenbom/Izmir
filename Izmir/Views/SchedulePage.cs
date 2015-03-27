using System;

using Xamarin.Forms;

namespace Izmir
{
	public class SchedulePage : ContentPage
	{
		public SchedulePage ()
		{
			Title = "Schedule";
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


