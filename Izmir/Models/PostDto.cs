using System;

namespace Izmir
{
	public class PostDto
	{
			public string id { get; set; }

			public string url { get; set; }

			public string title { get; set; }

			public string content { get; set; }

			public string excerpt { get; set; }

			public string date { get; set; }

			public string thumbnail { get; set; }

	}
	public class RootDtoObject
	{
			public PostDto[] posts { get; set; }
	}
}

