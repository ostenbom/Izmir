using System;
using Xamarin.Forms;
using Izmir;
using Izmir.iOS;
using System.IO;
using SQLite.Net.Async;
using SQLite.Net.Platform.XamarinIOS;
using SQLite.Net;

[assembly: Dependency (typeof (SQLite_iOS))]

namespace Izmir.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLiteAsyncConnection GetConnection ()
		{
			var sqliteFilename = "Posts.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath, sqliteFilename);

			var platform = new SQLitePlatformIOS ();

			var connectionWithLock = new SQLiteConnectionWithLock (
				platform,
				new SQLiteConnectionString (path, true));

			var connection = new SQLiteAsyncConnection (() => connectionWithLock);

			return connection;
		}
	}
}

