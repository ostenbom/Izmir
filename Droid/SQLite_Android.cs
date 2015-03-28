using System;
using Xamarin.Forms;
using Izmir;
using Izmir.Droid;
using System.IO;
using SQLite.Net.Async;
using SQLite.Net.Platform.XamarinAndroid;
using SQLite.Net;

[assembly: Dependency (typeof (SQLite_Android))]

namespace Izmir.Droid
{
	public class SQLite_Android : ISQLite
	{
		public SQLiteAsyncConnection GetConnection ()
		{
			var sqliteFilename = "Posts.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);

			var path = Path.Combine (documentsPath, sqliteFilename);

			var platform = new SQLitePlatformAndroid ();

			var connectionWithLock = new SQLiteConnectionWithLock (
				platform,
				new SQLiteConnectionString (path, true));

			var connection = new SQLiteAsyncConnection (() => connectionWithLock);

			return connection;
		}
	}
}

