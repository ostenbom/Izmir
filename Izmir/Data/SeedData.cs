using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Izmir
{
	public class SeedData : List<Post>
	{
		public SeedData()
		{
			Add (new Post () {
				id = "10000000",
				url = "",
				title = "Welcome to the İzmir 2015 App!",
				content = "Thanks for downloading it, just slide all the way to the right and pull up next time you're connected to the internet and we can get started!",
				excerpt = "Cheers for downloading the best EYP app in history",
				date = "2015-04-15",
				thumbnail = "example1.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "Who are we?",
				content = "The media team of the 78th International Session in İzmir.",
				excerpt = "We're IZMEDIA:",
				date = "2015-04-14",
				thumbnail = "example2.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "What am I doing here?",
				content = "We've made this app for you, to enjoy what we create, to stay on schedule, to remember the session, to prepare academically.",
				excerpt = "Enjoying.",
				date = "2015-04-13",
				thumbnail = "example3.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "What can I expect?",
				content = "We're sure that İzmir will be a success - but just to make sure there's a turkish dictionary and some phone numbers should you feel lost at any time.",
				excerpt = "One really fantastic experience.",
				date = "2015-04-12",
				thumbnail = "example4.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "What are you waiting for!?",
				content = "So what are you waiting for!? Just scroll to the right, find yourself some internet and prepare for something really special.",
				excerpt = "The party starts before we even get to Izmir.",
				date = "2015-04-11",
				thumbnail = "itre.jpg"
			});

		}
	}
	public class SeedOData : ObservableCollection<Post>
	{
		public SeedOData()
		{
			Add (new Post () {
				id = "10000000",
				url = "",
				title = "Welcome to the İzmir 2015 App!",
				content = "Thanks for downloading it, just slide all the way to the right and pull up next time you're connected to the internet and we can get started!",
				excerpt = "Cheers for downloading the best EYP app in history",
				date = "2015-04-15",
				thumbnail = "example1.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "Who are we?",
				content = "The media team of the 78th International Session in İzmir.",
				excerpt = "We're IZMEDIA:",
				date = "2015-04-14",
				thumbnail = "example2.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "What am I doing here?",
				content = "We've made this app for you, to enjoy what we create, to stay on schedule, to remember the session, to prepare academically.",
				excerpt = "Enjoying.",
				date = "2015-04-13",
				thumbnail = "example3.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "What can I expect?",
				content = "We're sure that İzmir will be a success - but just to make sure there's a turkish dictionary and some phone numbers should you feel lost at any time.",
				excerpt = "One really fantastic experience.",
				date = "2015-04-12",
				thumbnail = "example4.jpg"
			});

			Add (new Post () {
				id = "10000000",
				url = "",
				title = "What are you waiting for!?",
				content = "So what are you waiting for!? Just scroll to the right, find yourself some internet and prepare for something really special.",
				excerpt = "The party starts before we even get to Izmir.",
				date = "2015-04-11",
				thumbnail = "itre.jpg"
			});

		}
	}
}

