using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;

namespace Izmir
{
	public class PostClient
	{
		public PostClient () {
		}

		public async Task<List<Post>> GetPosts ()
		{ 
			var rootobject = new Rootobject();

			using (var httpClient = CreateClient ()) {
				try {
					var response = await httpClient.GetAsync ("get_category_posts/?category_id=11&date_format=Y-m-d&include=id,title,thumbnail,date,content,url,excerpt&count=5").ConfigureAwait(false);
					if (response.IsSuccessStatusCode) {
						var json = await response.Content.ReadAsStringAsync ().ConfigureAwait (false);
						if (!string.IsNullOrWhiteSpace (json)) {
							rootobject = await Task.Run (() => 
								JsonConvert.DeserializeObject<Rootobject> (json)
							).ConfigureAwait (false);
						}
					}
				} catch (Exception e) {
					System.Diagnostics.Debug.WriteLine ("Exception Posts Client {0}", e);
					return null;
				}
			}

			return rootobject.posts.ToList();
		}

		private const string ApiBaseAddress = "http://media.izmir2015.org/api/";
		private HttpClient CreateClient ()
		{
			var httpClient = new HttpClient 
			{ 
				BaseAddress = new Uri(ApiBaseAddress)
			};

			httpClient.Timeout = TimeSpan.FromSeconds (5);

			httpClient.DefaultRequestHeaders.Accept.Clear();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			return httpClient;
		}
	}
}

