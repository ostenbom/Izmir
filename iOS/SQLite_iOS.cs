using System;
using Xamarin.Forms;
using Izmir;
using Izmir.iOS;
using System.IO;

[assembly: Dependency (typeof (SQLite_iOS))]

namespace Izmir.iOS
{
	public class SQLite_iOS : ISQLite {
		public SQLite_iOS () {}
		public SQLite.Net.SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "IzmirSQLite.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);
			// Create the connection
			var plat = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
			var conn = new SQLite.Net.SQLiteConnection(plat, path);
			// Return the database connection
			return conn;
		}}
}

