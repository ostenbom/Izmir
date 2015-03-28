using System;
using SQLite.Net.Async;

namespace Izmir
{
	public interface ISQLite
	{
		SQLiteAsyncConnection GetConnection();
	}
}

