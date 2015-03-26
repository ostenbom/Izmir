using System;

using Xamarin.Forms;

namespace Izmir
{
	public class OtherPage : ContentPage
	{
		public OtherPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


