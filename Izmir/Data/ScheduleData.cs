using System;
using System.Collections.Generic;

namespace Izmir
{
	public class ScheduleData : List<Day>
	{
		public ScheduleData ()
		{
			this.Add (new Day () {
				day = new DateTime(2015,03,29),
				events = new Event[] {
					new Event () {
						start = new DateTime(2015,3,29,12,30,00),
						end = new DateTime(2015, 3, 29, 16, 30, 00),
						description = "Todays Event"
					},
					new Event () {
						start = new DateTime(2015,3,29, 16,30,00),
						end = new DateTime(2015, 3, 29, 17, 30, 00),
						description = "Todays Event: Burgers!"
					}}

			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 17),
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 17, 00, 00, 00),
						end = new DateTime(2015, 4, 17, 21, 00, 00),
						description = "Arrivals"
					},
					new Event () {
						start = new DateTime(2015, 4, 17, 21, 00, 00),
						end = new DateTime(2015, 4, 18, 01, 00, 00),
						description = "Welcome Party"
					}}

			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 18),
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 18, 07, 30, 00),
						end = new DateTime(2015, 4, 18, 08, 30, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 18, 08, 45, 00),
						end = new DateTime(2015, 4, 18, 10, 30, 00),
						description = "Opening of Teambuilding"
					}, new Event () {
						start = new DateTime(2015, 4, 18, 10, 30, 00),
						end = new DateTime(2015, 4, 18, 13, 00, 00),
						description = "Teambuilding"
					}, new Event () {
						start = new DateTime(2015, 4, 18, 13, 00, 00),
						end = new DateTime(2015, 4, 18, 14, 00, 00),
						description = "Lunch"
					}, new Event () {
						start = new DateTime(2015, 4, 18, 14, 00, 00),
						end = new DateTime(2015, 4, 18, 18, 00, 00),
						description = "Teabuilding"
					}, new Event () {
						start = new DateTime(2015, 4, 18, 18, 00, 00),
						end = new DateTime(2015, 4, 18, 19, 30, 00),
						description = "Eurovillage preparations and free-time"
					}, new Event () {
						start = new DateTime(2015, 4, 18, 19, 30, 00),
						end = new DateTime(2015, 4, 18, 22, 00, 00),
						description = "Eurovillage"
					}, new Event () {
						start = new DateTime(2015, 4, 18, 22, 00, 00),
						end = new DateTime(2015, 4, 18, 23, 30, 00),
						description = "Europarty"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 19),
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 17, 07, 30, 00),
						end = new DateTime(2015, 4, 17, 08, 30, 00),
						description = "Breakfast"
					}

				}
			});
		}
	}
}

