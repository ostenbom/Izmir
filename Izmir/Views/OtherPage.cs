using System;

using Xamarin.Forms;

namespace Izmir
{
	public class OtherPage : ContentPage
	{
		public OtherPage ()
		{
			Title = "Other Things";

			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


