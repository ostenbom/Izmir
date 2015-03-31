using System;
using System.Collections.Generic;

namespace Izmir
{
	public class ScheduleData : List<Day>
	{
		public ScheduleData ()
		{
			this.Add (new Day () {
				day = new DateTime(2015, 04, 17),
				image = "teos.jpg",
				title = "Arrivals Day",
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
				image = "tb1.jpg",
				title = "Teambuilding Day 1",
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
				image = "tb1.jpg",
				title = "Teambuilding Day 2",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 19, 07, 30, 00),
						end = new DateTime(2015, 4, 19, 08, 30, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 19, 08, 45, 00),
						end = new DateTime(2015, 4, 19, 13, 00, 00),
						description = "Teambuilding"
					}, new Event () {
						start = new DateTime(2015, 4, 19, 13, 00, 00),
						end = new DateTime(2015, 4, 19, 14, 00, 00),
						description = "Lunch"
					}, new Event () {
						start = new DateTime(2015, 4, 19, 14, 00, 00),
						end = new DateTime(2015, 4, 19, 19, 00, 00),
						description = "Teambuilding"
					}, new Event () {
						start = new DateTime(2015, 4, 19, 19, 30, 00),
						end = new DateTime(2015, 4, 19, 23, 30, 00),
						description = "Turkish Night"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 20),
				image = "cw1.jpg",
				title = "Committee Work and Opening Ceremony",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 20, 07, 30, 00),
						end = new DateTime(2015, 4, 20, 08, 30, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 20, 08, 30, 00),
						end = new DateTime(2015, 4, 20, 13, 00, 00),
						description = "Committee Work"
					}, new Event () {
						start = new DateTime(2015, 4, 20, 13, 00, 00),
						end = new DateTime(2015, 4, 20, 14, 00, 00),
						description = "Lunch"
					}, new Event () {
						start = new DateTime(2015, 4, 20, 14, 00, 00),
						end = new DateTime(2015, 4, 20, 16, 30, 00),
						description = "Committee Work"
					}, new Event () {
						start = new DateTime(2015, 4, 20, 16, 45, 00),
						end = new DateTime(2015, 4, 20, 18, 45, 00),
						description = "Transfer to Opening Ceremony"
					}, new Event () {
						start = new DateTime(2015, 4, 20, 18, 45, 00),
						end = new DateTime(2015, 4, 20, 20, 00, 00),
						description = "Welcome Reception and Buffet Dinner"
					}, new Event () {
						start = new DateTime(2015, 4, 20, 20, 00, 00),
						end = new DateTime(2015, 4, 20, 22, 00, 00),
						description = "Opening Ceremony"
					}, new Event () {
						start = new DateTime(2015, 4, 20, 22, 00, 00),
						end = new DateTime(2015, 4, 20, 23, 30, 00),
						description = "Transfer to Teos Village"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 21),
				image = "cw2.jpg",
				title = "Committee Work Day 2",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 21, 07, 30, 00),
						end = new DateTime(2015, 4, 21, 08, 30, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 21, 08, 30, 00),
						end = new DateTime(2015, 4, 21, 13, 00, 00),
						description = "Committee Work"
					}, new Event () {
						start = new DateTime(2015, 4, 21, 13, 00, 00),
						end = new DateTime(2015, 4, 21, 14, 00, 00),
						description = "Lunch"
					}, new Event () {
						start = new DateTime(2015, 4, 21, 14, 00, 00),
						end = new DateTime(2015, 4, 21, 18, 30, 00),
						description = "Committee Work"
					}, new Event () {
						start = new DateTime(2015, 4, 21, 18, 30, 00),
						end = new DateTime(2015, 4, 21, 19, 30, 00),
						description = "Transfer to Committee Dinners"
					}, new Event () {
						start = new DateTime(2015, 4, 21, 19, 30, 00),
						end = new DateTime(2015, 4, 21, 21, 30, 00),
						description = "Committee Dinners"
					}, new Event () {
						start = new DateTime(2015, 4, 21, 21, 30, 00),
						end = new DateTime(2015, 4, 21, 22, 30, 00),
						description = "Transfer to Teos Village"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 22),
				image = "cw1.jpg",
				title = "Last Day of Committee Work",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 22, 07, 00, 00),
						end = new DateTime(2015, 4, 22, 08, 00, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 08, 00, 00),
						end = new DateTime(2015, 4, 22, 09, 00, 00),
						description = "Check Out"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 09, 00, 00),
						end = new DateTime(2015, 4, 22, 12, 30, 00),
						description = "Committee Work"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 12, 30, 00),
						end = new DateTime(2015, 4, 22, 13, 30, 00),
						description = "Lunch"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 13, 30, 00),
						end = new DateTime(2015, 4, 22, 16, 30, 00),
						description = "Committee Work"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 16, 30, 00),
						end = new DateTime(2015, 4, 22, 17, 15, 00),
						description = "Free Time"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 17, 15, 00),
						end = new DateTime(2015, 4, 22, 18, 30, 00),
						description = "Transfer to Kaya"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 18, 30, 00),
						end = new DateTime(2015, 4, 22, 19, 30, 00),
						description = "Check-in to Kaya"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 19, 30, 00),
						end = new DateTime(2015, 4, 22, 20, 15, 00),
						description = "Theme Party Preparations"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 20, 15, 00),
						end = new DateTime(2015, 4, 22, 21, 00, 00),
						description = "Transfer to Theme Party"
					}, new Event () {
						start = new DateTime(2015, 4, 22, 21, 00, 00),
						end = new DateTime(2015, 4, 23, 01, 30, 00),
						description = "Theme Party: The Great Gatsby"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 01, 30, 00),
						end = new DateTime(2015, 4, 23, 02, 10, 00),
						description = "Transfer to Kaya"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 23),
				image = "ephesus.jpg",
				title = "GA Prep and Historical Tour",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 23, 08, 30, 00),
						end = new DateTime(2015, 4, 23, 09, 30, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 09, 30, 00),
						end = new DateTime(2015, 4, 23, 11, 00, 00),
						description = "Transfer to the Ephesus"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 11, 00, 00),
						end = new DateTime(2015, 4, 23, 14, 00, 00),
						description = "Historical Tour"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 14, 00, 00),
						end = new DateTime(2015, 4, 23, 15, 45, 00),
						description = "Transfer to Kaya"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 15, 45, 00),
						end = new DateTime(2015, 4, 23, 18, 15, 00),
						description = "General Assembly Preparation"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 18, 15, 00),
						end = new DateTime(2015, 4, 23, 19, 00, 00),
						description = "Euroconcert Preparations"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 19, 00, 00),
						end = new DateTime(2015, 4, 23, 19, 45, 00),
						description = "Transfer to Euroconcert"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 19, 45, 00),
						end = new DateTime(2015, 4, 23, 21, 15, 00),
						description = "Euroconcert Reception and Buffet Dinner"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 21, 15, 00),
						end = new DateTime(2015, 4, 23, 22, 45, 00),
						description = "Euroconcert"
					}, new Event () {
						start = new DateTime(2015, 4, 23, 22, 45, 00),
						end = new DateTime(2015, 4, 23, 23, 30, 00),
						description = "Transfer to Kaya"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 24),
				image = "ga1.jpg",
				title = "General Assembly Day 1",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 24, 07, 00, 00),
						end = new DateTime(2015, 4, 24, 08, 00, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 08, 00, 00),
						end = new DateTime(2015, 4, 24, 08, 45, 00),
						description = "Transfer to GA"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 09, 00, 00),
						end = new DateTime(2015, 4, 24, 10, 00, 00),
						description = "Opening of the General Assembly"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 10, 00, 00),
						end = new DateTime(2015, 4, 24, 10, 50, 00),
						description = "General Assembly I"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 10, 50, 00),
						end = new DateTime(2015, 4, 24, 11, 20, 00),
						description = "Coffee Break"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 11, 20, 00),
						end = new DateTime(2015, 4, 24, 13, 00, 00),
						description = "General Assembly II-III"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 13, 00, 00),
						end = new DateTime(2015, 4, 24, 14, 00, 00),
						description = "Lunch"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 14, 00, 00),
						end = new DateTime(2015, 4, 24, 15, 40, 00),
						description = "General Assembly IV-V"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 15, 40, 00),
						end = new DateTime(2015, 4, 24, 16, 10, 00),
						description = "Coffee Break"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 16, 10, 00),
						end = new DateTime(2015, 4, 24, 17, 50, 00),
						description = "General Assembly VI-VII"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 17, 50, 00),
						end = new DateTime(2015, 4, 24, 18, 20, 00),
						description = "Coffee Break"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 18, 20, 00),
						end = new DateTime(2015, 4, 24, 19, 10, 00),
						description = "General Assembly VIII"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 19, 20, 00),
						end = new DateTime(2015, 4, 24, 20, 00, 00),
						description = "Transfer to Delegation Dinners"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 20, 00, 00),
						end = new DateTime(2015, 4, 24, 22, 00, 00),
						description = "Delegation Dinners"
					}, new Event () {
						start = new DateTime(2015, 4, 24, 22, 00, 00),
						end = new DateTime(2015, 4, 24, 23, 00, 00),
						description = "Transfer to Kaya"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 25),
				image = "ga2.jpg",
				title = "GA Day 2 & Farewell",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 25, 07, 00, 00),
						end = new DateTime(2015, 4, 25, 08, 00, 00),
						description = "Breakfast"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 08, 00, 00),
						end = new DateTime(2015, 4, 25, 08, 45, 00),
						description = "Transfer to GA"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 09, 00, 00),
						end = new DateTime(2015, 4, 25, 10, 40, 00),
						description = "General Assembly IX-X"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 10, 40, 00),
						end = new DateTime(2015, 4, 25, 11, 10, 00),
						description = "Coffee Break"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 11, 10, 00),
						end = new DateTime(2015, 4, 25, 12, 50, 00),
						description = "General Assembly XI-XII"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 13, 00, 00),
						end = new DateTime(2015, 4, 25, 14, 00, 00),
						description = "Lunch"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 14, 00, 00),
						end = new DateTime(2015, 4, 25, 15, 40, 00),
						description = "General Assembly XIII-XIV"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 15, 40, 00),
						end = new DateTime(2015, 4, 25, 16, 10, 00),
						description = "Coffee Break"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 16, 10, 00),
						end = new DateTime(2015, 4, 25, 17, 00, 00),
						description = "General Assembly XV"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 17, 00, 00),
						end = new DateTime(2015, 4, 25, 18, 30, 00),
						description = "Closing Ceremony"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 18, 30, 00),
						end = new DateTime(2015, 4, 25, 19, 30, 00),
						description = "Dinner"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 19, 30, 00),
						end = new DateTime(2015, 4, 25, 20, 15, 00),
						description = "Transfer to Kaya"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 20, 15, 00),
						end = new DateTime(2015, 4, 25, 21, 15, 00),
						description = "Farewell Party Preparations"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 21, 15, 00),
						end = new DateTime(2015, 4, 25, 22, 00, 00),
						description = "Transfer to Farewell Party"
					}, new Event () {
						start = new DateTime(2015, 4, 25, 22, 00, 00),
						end = new DateTime(2015, 4, 26, 03, 00, 00),
						description = "Farewell Party"
					}, new Event () {
						start = new DateTime(2015, 4, 26, 03, 00, 00),
						end = new DateTime(2015, 4, 26, 03, 30, 00),
						description = "Transfer to Kaya"
					}

				}
			});
			this.Add (new Day () {
				day = new DateTime(2015, 04, 26),
				image = "izmir.jpg",
				title = "Departures Day",
				events = new Event[] {
					new Event () {
						start = new DateTime(2015, 4, 26, 04, 00, 00),
						end = new DateTime(2015, 4, 26, 10, 00, 00),
						description = "Check-Out"
					},
					new Event () {
						start = new DateTime(2015, 4, 26, 10, 00, 00),
						end = new DateTime(2015, 4, 26, 23, 59, 59),
						description = "Departures"
					}}

			});
		}
	}
}

