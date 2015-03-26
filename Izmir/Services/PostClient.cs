using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Izmir
{
	public class PostClient
	{
		public PostClient () {
		}

		public async Task<Post[]> GetPostsAsync () {

			var client = new HttpClient ();

			client.BaseAddress = new Uri("http://www.barcelonaismedia.com/");

			var response = await client.GetAsync("?json=get_posts&date_format=Y-m-d&include=id,title,thumbnail,date,content,url,excerpt&count=10");

			var postJson = response.Content.ReadAsStringAsync().Result;

			var rootobject = JsonConvert.DeserializeObject<Rootobject>(postJson);

			return rootobject.posts;

		}
	}
}

