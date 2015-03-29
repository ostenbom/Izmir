using Xamarin.Forms;
using Izmir.iOS;
using Foundation;

[assembly: Dependency (typeof (BaseUrl_iOS))]

namespace Izmir.iOS 
{
	public class BaseUrl_iOS : IBaseUrl 
	{
		public string Get () 
		{
			return NSBundle.MainBundle.BundlePath;
		}
	}
}