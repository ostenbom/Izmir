using System;
using Xamarin.Forms;
using SQLite.Net.Async;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Izmir
{
	public class PostsDatabase
	{
		private static readonly AsyncLock Mutex = new AsyncLock ();
		private readonly SQLiteAsyncConnection database;

		public PostsDatabase ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			CreateDatabaseAsync ();
		}

		public async Task CreateDatabaseAsync ()
		{
			using (await Mutex.LockAsync ().ConfigureAwait (false)) {
				await database.CreateTableAsync<Post> ().ConfigureAwait (false);
			}
		}

		public async Task<List<Post>> GetPostsAsync ()
		{
			List<Post> posts = new List<Post> ();
			using (await Mutex.LockAsync ().ConfigureAwait (false)) {
				posts = await database.Table<Post> ().ToListAsync ().ConfigureAwait (false);
			}

			return posts;
		}

		public async Task Save (Post post)
		{
			using (await Mutex.LockAsync ().ConfigureAwait (false)) {
				// Because our conference model is being mapped from the dto,
				// we need to check the database by name, not id
				var existingPost = await database.Table<Post> ()
					.Where (x => x.id == post.id)
					.FirstOrDefaultAsync ();

				if (existingPost == null) {
					await database.InsertAsync (post).ConfigureAwait (false);
				} else {
					post.id = existingPost.id;
					await database.UpdateAsync (post).ConfigureAwait (false);
				}
			}
		}

		public async Task SaveAll (IEnumerable<Post> posts)
		{
			foreach (var post in posts) {
				await Save (post);
			}
		}
	}
}

