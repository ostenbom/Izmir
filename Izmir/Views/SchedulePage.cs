using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Izmir
{
	public class SchedulePage : ContentPage
	{

		readonly List<Day> days = new ScheduleData ();

		readonly Label currentevent = new Label () { FontSize = 30, HorizontalOptions = LayoutOptions.Center };

		readonly DateTime izmirstart = new DateTime (2015, 04, 17);

		readonly DateTime izmirend = new DateTime (2015, 04, 25, 18, 30, 00);

		readonly DateTime izmirshowend = new DateTime (2015, 04, 27);

		public SchedulePage ()
		{
			Title = "Schedule";

			DateTime now = DateTime.Now;

			TableRoot root = new TableRoot {};

			if (now < izmirstart) {
				int numdays = (izmirstart - now).Days;
				if (numdays == 1) {
					currentevent.Text = numdays + " day left!";
				} else {
					currentevent.Text = numdays + " days until Izmir IS!";
				}
			};

			if (now > izmirshowend) {
				int numdays = (now - izmirend).Days;
				if (numdays == 1) {
					currentevent.Text = numdays + " day since Izmir.";
				} else {
					currentevent.Text = numdays + " days since Izmir IS";
				}
			};

			foreach (Day d in days) {
				TableSection ts = new TableSection (d.day.ToString("M")) {};
				foreach (Event e in d.events) {
					string s = e.start.ToString("HH:mm") + " - " + e.end.ToString("HH:mm");
					TextCell t = new TextCell {
						Text = "     "+e.description,
						Detail = "     "+s
					};
					ts.Add (t);
					if ((now > e.start) && (now < e.end))
					{
						currentevent.Text = e.description;
					}
				};
				root.Add (ts);
			};

			if (currentevent.Text == null) {
				currentevent.Text = "In between Events!";
			}

			TableView table = new TableView {
				Intent = TableIntent.Menu,
				Root = root
			};
					

			Content = new StackLayout { 
				Children = {
					currentevent,
					table
				}
			};

			Device.StartTimer (TimeSpan.FromSeconds(30), OnTimeUpdate);
		}

		bool OnTimeUpdate() {
			DateTime now = DateTime.Now;

			if (now < izmirstart) {
				int numdays = (izmirstart - now).Days;
				if (numdays == 1) {
					currentevent.Text = numdays + " day left!";
				} else {
					currentevent.Text = numdays + " days until Izmir IS!";
				}
			} else {
				if (now > izmirshowend) {
					int numdays = (now - izmirend).Days;
					if (numdays == 1) {
						currentevent.Text = numdays + " day since Izmir.";
					} else {
						currentevent.Text = numdays + " days since Izmir IS";
					}
				} else {
					foreach (Day d in days) {
						foreach (Event e in d.events) {
							if ((now > e.start) && (now < e.end))
							{
								currentevent.Text = e.description;
							}
						};
					};
				}
			}
			return true;
		}
	}
}


