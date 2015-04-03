using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropertyChanged;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite;
using System.Collections.ObjectModel;

namespace Izmir
{
	[ImplementPropertyChanged]
	public class PostsViewModel : BaseViewModel
	{
		
		readonly PostsDatabase db;

		public PostsViewModel ()
		{
			db = new PostsDatabase ();
		}

		public List<Post> Posts { get; set; }

		public int PostCount { get; set; }

		public ObservableCollection<Post> _Oposts = new ObservableCollection<Post> ();

		public ObservableCollection<Post> Oposts { get { return _Oposts; } }

		public async Task GetPosts (int num, int off)
		{
			await GetRemotePosts (num, off);
			System.Diagnostics.Debug.WriteLine ("Got Remote Posts");
			await GetLocalPosts ();
			System.Diagnostics.Debug.WriteLine ("Got Local Posts");
		}

		private async Task GetLocalPosts()
		{
			var posts = await db.GetPostsAsync ();
			var orderposts = posts.OrderByDescending (o => o.date);
			Posts = posts.OrderByDescending(o=>o.date).ToList();
			foreach (Post p in orderposts){
				try {
				_Oposts.Add (p);
				} catch (Exception e) {
					System.Diagnostics.Debug.WriteLine ("OC Problem: {0}", e);
				}
			}
			System.Diagnostics.Debug.WriteLine ("Got Each Local Post");
		}

		private async Task GetRemotePosts(int num, int off)
		{
			var remoteClient = new PostClient ();
			var posts = await remoteClient.GetPosts (num, off).ConfigureAwait(false);
			this.PostCount = await remoteClient.GetPostCount ().ConfigureAwait (false);
			System.Diagnostics.Debug.WriteLine ("Getting Somewhere");
			if(posts != null){
				await db.SaveAll (posts).ConfigureAwait (false);
			}
		}

		public async Task GetMorePosts (int num, int off)
		{
			await GetMoreRemotePosts (num, off);
			System.Diagnostics.Debug.WriteLine ("Got Remote Posts");
		}

		private async Task GetMoreRemotePosts(int num, int off)
		{
			var remoteClient = new PostClient ();
			List<Post> remoteposts = null;
			remoteposts = await remoteClient.GetPosts (num, off).ConfigureAwait(false);
			this.PostCount = await remoteClient.GetPostCount ().ConfigureAwait (false);
			foreach (Post rp in remoteposts){
				try {
					_Oposts.Add (rp);
				} catch (Exception e) {
					System.Diagnostics.Debug.WriteLine ("OC Problem: {0}", e);
				}
			}
			System.Diagnostics.Debug.WriteLine ("Got More Posts!");
			if(remoteposts != null){
				await db.SaveAll (remoteposts).ConfigureAwait (false);
			}
		}

	}
}

