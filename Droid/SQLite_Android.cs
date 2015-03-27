using System;
using Xamarin.Forms;
using Izmir;
using Izmir.Droid;
using System.IO;

[assembly: Dependency (typeof (SQLite_Android))]

namespace Izmir.Droid
{
	public class SQLite_Android : ISQLite {
		public SQLite_Android () {}
		public SQLite.Net.SQLiteConnection GetConnection () {
			var sqliteFilename = "IzmirSQLite.db3";
			string documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);
			// Create the connection
			var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
			var conn = new SQLite.Net.SQLiteConnection(plat, path);
			// Return the database connection 
			return conn;
		}}
}

