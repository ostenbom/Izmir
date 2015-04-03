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

		public async Task<List<Post>> GetPosts (int num, int off)
		{ 
			var rootobject = new Rootobject();

			using (var httpClient = CreateClient ()) {
				try {
					string url = "get_category_posts/?category_id=11&include=id,title,thumbnail,date,content,url,excerpt&count=" + num + "&offset=" + off;
					var response = await httpClient.GetAsync (url).ConfigureAwait(false);
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
		public async Task<Category> GetPostCount ()
		{ 
			var rootcategory = new RootCategory();

			using (var httpClient = CreateClient ()) {
				try {
					string url = "get_category_posts/?category_id=11&include=id&count=1";
					var response = await httpClient.GetAsync (url).ConfigureAwait(false);
					if (response.IsSuccessStatusCode) {
						var json = await response.Content.ReadAsStringAsync ().ConfigureAwait (false);
						if (!string.IsNullOrWhiteSpace (json)) {
							rootcategory = await Task.Run (() => 
								JsonConvert.DeserializeObject<RootCategory> (json)
							).ConfigureAwait (false);
						}
					}
				} catch (Exception e) {
					System.Diagnostics.Debug.WriteLine ("Exception Posts Client {0}", e);
					return null;
				}
			}
			return rootcategory.category;
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

