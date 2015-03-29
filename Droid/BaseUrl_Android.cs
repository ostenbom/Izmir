using System;
using Xamarin.Forms;
using Izmir.Droid;
using Izmir;

[assembly: Dependency (typeof (BaseUrl_Android))]
namespace Izmir.Droid 
{
	public class BaseUrl_Android : IBaseUrl 
	{
		public string Get () 
		{
			return "file:///android_asset/";
		}
	}
}