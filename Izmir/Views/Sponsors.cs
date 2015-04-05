using System;

using Xamarin.Forms;

namespace Izmir
{
	public class Sponsors : ContentPage
	{
		public Sponsors ()
		{
			Title = "Sponsors";
			Content = new ScrollView { Content = new StackLayout { 
					Children = {
						new Image { Aspect = Aspect.AspectFill, Source = "sponsorstable.png" }
					}
				}
			};
		}
	}
}


