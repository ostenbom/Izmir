using System;

namespace Izmir
{
	public class RootImages
	{
		public RootImage photos { get; set; }
	}
	public class RootImage
	{
		public Flickr[] photo { get; set; }
	}
	public class Flickr
	{
		public string id { get; set; }

		public string title { get; set; }

		public string url_q { get; set; }

		public string url_l { get; set; }

	}
}

