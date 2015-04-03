using System;
using Xamarin.Forms;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using Newtonsoft.Json;
using System.Globalization;

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

		public string featured { get; set; }


		/*public DateTime published { 
			get { 
				try {
					DateTime publishtime = DateTime.ParseExact (date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

				return publishtime;
				} catch (Exception e) {
					System.Diagnostics.Debug.WriteLine("Date Time Published: {0}", e);
					return new DateTime(2015, 05, 23);
				}
			}
		}

		public string nicedate {
			get { 
				try {
					var nice = published.ToString("M");
					return nice;
				} catch (Exception e) {
					System.Diagnostics.Debug.WriteLine("Humanize Error: {0}", e);
					return published.ToString();
				}
			}
		}*/

		public string thumbnail { get; set; }

		/*public List<Author> authors { get; set; }*/

	}
	public class Rootobject
	{
		public Post[] posts { get; set; }
	}
}


