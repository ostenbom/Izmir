using System;

namespace Izmir
{
	public class Event
	{
		public DateTime start { get; set; }

		public DateTime end { get; set; }

		public string description { get; set; }
	}

	public class Day
	{
		public DateTime day { get; set; }

		public Event[] events { get; set; }
	}
}

