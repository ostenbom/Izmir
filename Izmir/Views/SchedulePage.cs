using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Izmir
{
	public class SchedulePage : ContentPage
	{
		public SchedulePage ()
		{
			Title = "Schedule";
			var time = DateTime.Now.ToString ("F");
			var date = DateTime.Now.ToString ("d");
			List<Day> days = new ScheduleData ();
			TableRoot root = new TableRoot {};

			foreach (Day d in days) {
				TableSection ts = new TableSection (d.day.ToString("M")) {};
				foreach (Event e in d.events) {
					string s = e.start.ToString("HH:mm") + " - " + e.end.ToString("HH:mm");
					TextCell t = new TextCell {
						Text = e.description,
						Detail = s
					};
					ts.Add (t);
				};
				root.Add (ts);
			};

			TableView table = new TableView {
				Intent = TableIntent.Menu,
				Root = root
			};
					

			Content = new StackLayout { 
				Children = {
					table
				}
			};
		}
	}
}


