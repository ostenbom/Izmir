using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using Izmir;
using Izmir.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageCustom))]

namespace Izmir
{
	public class TabbedPageCustom : TabbedRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);
			if (e.OldElement == null) {
				TabBar.TintColor = UIColor.White;
				TabBar.BarTintColor = UIColor.FromRGB (33, 144, 166);
			}
		}
	}
}

