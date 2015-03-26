using System;
using SQLite.Net;

namespace Izmir
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

