using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Izmir
{
	public class PostsDatabase
	{
		static object locker = new object ();

		SQLiteConnection database;

		public PostsDatabase ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			// create the tables
			database.CreateTable<Post>();

			InitializePosts ();

		}

		void InitializePosts ()
		{
			Post post;

			lock (locker) {
				post = database.Table<Post> ().FirstOrDefault ();
			};

			if (post == null) {
				lock (locker) {
					var seeds = SeedData.GetSeedData ();
					foreach (var seed in seeds) {
						database.Insert (seed);
					}
				}
			} else {
				UpdatePosts ();
			}
		}

		public async void UpdatePosts ()
		{
			var cl = new PostClient ();
			var p = await cl.GetPostsAsync ();

			if (p.Count () == 0)
				return;
			lock (locker) {
				database.Execute ("delete from Post");
				foreach (var a in p) {
					database.Insert (a);
				}
			}
		}

		public List<Post> GetPosts() {
			lock (locker) {
				return database.Table<Post> ().ToList<Post> ();
			}
		}
	}
}

