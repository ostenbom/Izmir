using System;
using Xamarin.Forms;
using System.Collections.Generic;
using SQLite.Net.Attributes;

namespace Izmir
{
	public class Post
	{
		[PrimaryKey]
		public string id { get; set; }

		public string url { get; set; }

		public string title { get; set; }

		public string content { get; set; }

		public string excerpt { get; set; }

		public string date { get; set; }

		public string thumbnail { get; set; }
	}
	public class Rootobject
	{
		public Post[] posts { get; set; }
	}
}


