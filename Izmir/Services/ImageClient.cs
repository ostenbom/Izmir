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
	public class ImageClient
	{
		public ImageClient ()
		{
		}
			
		public async Task<List<Flickr>> GetImages ()
		{
			var rootimages = new RootImages ();
			using (var httpImageClient = CreateImageClient ()) {
				try {
					var imageresponse = await httpImageClient.GetAsync ("?method=flickr.people.getPublicPhotos&api_key=05c1f8f86d099482489854588a178464&user_id=131444764%40N03&extras=url_q%2C+url_l&format=json&nojsoncallback=1&per_page=16").ConfigureAwait(false);
					if (imageresponse.IsSuccessStatusCode) {
						var json = await imageresponse.Content.ReadAsStringAsync ().ConfigureAwait (false);
						if (!string.IsNullOrWhiteSpace (json)) {
							rootimages = await Task.Run (() => 
								JsonConvert.DeserializeObject<RootImages> (json)
							).ConfigureAwait (false);
						}
					}
				} catch (Exception e) {
					System.Diagnostics.Debug.WriteLine ("Exception Image Client {0}", e);
					return null;
				}
			}

			return rootimages.photos.photo.ToList ();

		}
		private const string FlickrBaseAddress = "https://api.flickr.com/services/rest/";
		private HttpClient CreateImageClient ()
		{
			var httpImageClient = new HttpClient 
			{ 
				BaseAddress = new Uri(FlickrBaseAddress)
			};

			httpImageClient.Timeout = TimeSpan.FromSeconds (5);

			httpImageClient.DefaultRequestHeaders.Accept.Clear();
			httpImageClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			return httpImageClient;
		}
	}
}

