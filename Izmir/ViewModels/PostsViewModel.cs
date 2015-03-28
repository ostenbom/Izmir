using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropertyChanged;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite;

namespace Izmir
{
	[ImplementPropertyChanged]
	public class PostsViewModel
	{
		readonly PostsDatabase db;

		public PostsViewModel ()
		{
			db = new PostsDatabase ();
		}

		public List<Post> Posts { get; set; }

		public async Task GetPosts ()
		{
			await GetRemotePosts ();
			System.Diagnostics.Debug.WriteLine ("Got Remote Posts");
			await GetLocalPosts ();
		}

		private async Task GetLocalPosts()
		{
			var posts = await db.GetPostsAsync ();
			this.Posts = posts;
			System.Diagnostics.Debug.WriteLine ("Got Each Local Post");
		}

		private async Task GetRemotePosts()
		{
			var remoteClient = new PostClient ();
			var posts = await remoteClient.GetPosts ().ConfigureAwait(false);
			System.Diagnostics.Debug.WriteLine ("Getting Somewhere");
			await db.SaveAll (posts).ConfigureAwait (false);
		}
	}
}

