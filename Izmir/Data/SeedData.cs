using System;
using System.Collections.Generic;

namespace Izmir
{
	public static class SeedData
	{
		public static List<Post> GetSeedData()
		{
			return new List<Post> () {
				new Post () {
					id = "100000000",
					url = "",
					title = "Welcome to the İzmir 2015 App!",
					content = "Thanks for downloading it, just click the refresh button in the top right when next time you're connected to the internet and we can get started!",
					excerpt = "Cheers for downloading the best EYP app in history",
					date = "2015-04-15",
					thumbnail = "example1.jpg"
				},
				new Post () {
					id = "100000001",
					url = "",
					title = "Welcome to the İzmir 2015 App!",
					content = "Thanks for downloading it, just click the refresh button in the top right when next time you're connected to the internet and we can get started!",
					excerpt = "Cheers for downloading the best EYP app in history",
					date = "2015-04-15",
					thumbnail = "example1.jpg"
				}
			};
		}
	}
}

