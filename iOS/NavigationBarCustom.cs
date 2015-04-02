using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using Izmir;
using Izmir.iOS;

//[assembly: ExportRenderer(typeof(NavigationPage), typeof(NavigationBarCustom))]

namespace Izmir
{
	public class NavigationBarCustom : NavigationRenderer
	{
		/*protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.OldElement == null) {
				try {
					if (NavigationBar.BarTintColor == null) {
					System.Diagnostics.Debug.WriteLine ("Navigation Render Color: {0}", NavigationBar.BarTintColor);
					NavigationBar.BarTintColor = UIColor.FromRGB(33, 144, 166);	
					System.Diagnostics.Debug.WriteLine ("Navigation Render Color Final: {0}", NavigationBar.BarTintColor);
					}
				} catch (Exception x) {
					System.Diagnostics.Debug.WriteLine ("Navigation Render Exception: {0}", x);
				}
			}
		}*/

		public NavigationBarCustom()
		{



		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.NavigationBar.TintColor = UIColor.White;
			this.NavigationBar.BarTintColor = UIColor.Cyan;
			this.NavigationBar.BarStyle = UIBarStyle.Black;
		}
	}
}