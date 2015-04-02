using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Izmir
{
	public class CommitteesListData : List<CommitteesItem>
	{
		public CommitteesListData ()
		{
			this.Add (new CommitteesItem () {
				Title = "AFCO I",
				Icon = "afcoi.jpg",
				Cover = "afcoil.jpg",
				Overview = "afcoi.html",
				ChairName = "Lea Schiewer",
				ChairQuote = "I am nordic by nature, a post card addict and cannot say no to cake and coffee. Backpack, paper and ink rule my world. I tried both climbing a volcano and living in Berlin.",
				JournoName = "Despina Dimitrakapoulou",
				JournoQuote = "Studying law, who knows what for? Clumsy as hell, bump everywhere. Coming from Greece, tanning with ease. Randomness spree, see you in Izmir!",
				ChairPic = "lea.jpg",
				JournoPic = "despina.jpg",
				Topic = "After almost a decade of accession negotiations and more than 15 years as a Candidate, how should the framework for exploiting the full potential of EU-Turkey relations look like?"
			});

			this.Add (new CommitteesItem () {
				Title = "AFCO II",
				Icon = "afcoii.jpg",
				Cover = "afcoiil.jpg",
				Overview = "afcoii.html",
				ChairName = "Oscar Stenbom",
				ChairQuote = "Oscar lives in York where he studies. He likes the usual kinds of things many others enjoy, like music, sports and cooking. He excels at writing mundane introductions. You should buy him a beer!",
				JournoName = "David Soler Crespo",
				JournoQuote = "Take into account that between day and night there's no wall. Life is a long-learning experience. Spanish, getting old, wanna a beer?",
				ChairPic = "oscar.jpg",
				JournoPic = "david.jpg",
				Topic = "How should the EU react to the ever-declining voter turnout in European elections, the low levels of trust in EU institutions and the rise of Eurosceptic parties?"

			});

			this.Add (new CommitteesItem () {
				Title = "AFET I",
				Icon = "afeti.jpg",
				Cover = "afetil.jpg",
				Overview = "afeti.html",
				ChairName = "Oona Kiiskinen",
				ChairQuote = "Following my degree in Scotland, I am now enjoying a gap year in Berlin - learning German, mapping out the city by cycling and making the most of the Berlin café scene.",
				JournoName = "Egzon Gashi",
				JournoQuote = "Who's got two thumbs and always screws up jokes? This guy!",
				ChairPic = "oona.jpg",
				JournoPic = "egzon2.jpg",
				Topic = "Crisis at the EU’s Eastern borders? Considering the ongoing violence in Eastern-Ukraine, what role should the EU play in bringing back peace and stability to Ukraine?"
			});

			this.Add (new CommitteesItem () {
				Title = "AFET II",
				Icon = "afetii.jpg",
				Cover = "afetiil.jpg",
				Overview = "afetii.html",
				ChairName = "Iuliia Pustovoitova",
				ChairQuote = "#kyiv #hr #work #eyp #chairing #music #travelling #mexicanfood #spicy #movies #summer #springisnotthatbadwhenyouregoingtoizmir #placetobe",
				JournoName = "Siebe Geerts",
				JournoQuote = "I am Siebe, from Belgium. I love cooking and food in general and I also enjoy playing rugby, meeting with friends and spending way too much money on traveling in the EYP. If you want to impress me, you’d have to do it through your taste in music or level of randomness. Apart from that, food might do the trick as well.",
				ChairPic = "julia.jpg",
				JournoPic = "siebe.jpg",
				Topic = "With numerous Member States taking part in military actions against the Islamic State in Iraq and the Levant (ISIL) and the European Council calling for a comprehensive strategy to tackle this threat, what measures should the EU take to eradicate violence and bring back stability to the region?"
			});

			this.Add (new CommitteesItem () {
				Title = "AGRI",
				Icon = "agri.jpg",
				Cover = "agril.jpg",
				Overview = "agri.html",
				ChairName = "Elisa Martinelli",
				ChairQuote = "\"All that is gold does not glitter, not all those who wander are lost.” - J.R.R. Tolkien, The Fellowship of the Ring.",
				JournoName = "Jesper Thunström",
				JournoQuote = "Blast music and dance around like nobody's watching and taste foods I can't pronounce the name of. Oh and the odd smile here and there.",
				ChairPic = "elisa.jpg",
				JournoPic = "jesper.jpg",
				Topic = "The second pillar of the EU’s Common Agricultural Policy (CAP): In light of the priorities announced for the Rural Development Policy (RDP) for the period 2014-2020, how should the EU endeavour to balance the competitiveness of its agricultural sector, sustainable management of natural resources and the territorial development of rural etconomies?"
			});

			this.Add (new CommitteesItem () {
				Title = "CLIM",
				Icon = "clim.jpg",
				Cover = "climl.jpg",
				Overview = "clim.html",
				ChairName = "Ciara Robinson",
				ChairQuote = "Since I am awful with creative quips or puns, I'll just steal a good quote from my old pal Socrates, 'Let him who would move the world first move himself'. Gotta start somewhere right?",
				JournoName = "Cristina Crespo",
				JournoQuote = "\"Look deep into nature, and then you will understand everything better.\" -  Albert Einstein",
				ChairPic = "ciara.jpg",
				JournoPic = "cristina.jpg",
				Topic = "The upcoming 2015 United Nations Climate Change Conference in Paris could mark a decisive stage in the negotiations of a post-2020 international agreement on climate change. What role should the EU play in the negotiations of a binding and universal climate agreement?"
			});

			this.Add (new CommitteesItem () {
				Title = "DEVE",
				Icon = "deve.jpg",
				Cover = "devel.jpg",
				Overview = "deve.html",
				ChairName = "Megan Smith",
				ChairQuote = "I'm a very busy person. Like, reaaallly busy. All the time. I like jumping on springy mats! Up! Down! Flip! Yeah! I desperately need hobbies outside of EYP & jumping on springy bouncy things.  Like studying law! In the library! Books! Words! Yay! ",
				JournoName = "Anna Barkemeyer",
				JournoQuote = "I'm Anna from Frankfurt in Germany. I really enjoy travelling, playing tennis, and sailing, and I also kind of have a thing for biology. ",
				ChairPic = "megan.jpg",
				JournoPic = "annab.jpg",
				Topic = "Donor or investor in the fight against poverty? With the European Commission declaring 2015 as the European Year for Development, what role should the EU play in supporting sustainable growth in developing countries?"
			});

			this.Add (new CommitteesItem () {
				Title = "ECON I",
				Icon = "econi.jpg",
				Cover = "econil.jpg",
				Overview = "econi.html",
				ChairName = "Chris Papadogeorgopoulos",
				ChairQuote = "Born and raised in Athens, currently reading Economics in the United Kingdom. Tennis aficionado, globetrotter, seasoned cook. May contain sarcasm.",
				JournoName = "Flora Böwing",
				JournoQuote = "While doing a Gap-Year life can get a bit boring. This is why I am trying to get the hang of model airplanes at the moment, those little beasts.",
				ChairPic = "chris.jpg",
				JournoPic = "flora.jpg",
				Topic = "Evasion versus avoidance? How should Member States address tax avoidance, while respecting their citizens’ right to privacy and Third-Party States’ sovereignty?"
			});

			this.Add (new CommitteesItem () {
				Title = "ECON II",
				Icon = "econii.jpg",
				Cover = "econiil.jpg",
				Overview = "econii.html",
				ChairName = "Mathilde Pascal",
				ChairQuote = "Atypical French, proud introvert, tea drinker, cat person, pseudo geek, food lover, maths enthusiast, etc.",
				JournoName = "Patrik Bruschek",
				JournoQuote = "I love eating Schnitzel, hanging out with friends, travelling the world and hope to get inspired by the participants of Izmir 2015.",
				ChairPic = "mathilde.jpg",
				JournoPic = "patrik.jpg",
				Topic = "With funding for European Small and Medium Enterprises (SMEs) coming primarily from banks and European Commission President Jean-Claude Juncker calling for a better access for SMEs to capital markets; what should the EU do to diversify the sources of funding, and cut the costs of raising capital, for SMEs?"
			});

			this.Add (new CommitteesItem () {
				Title = "FEMM",
				Icon = "femm.jpg",
				Cover = "femml.jpg",
				Overview = "femm.html",
				ChairName = "Sophie Scannell",
				ChairQuote = "Mathematician, morning person, improving cyclist and disimproving runner, I spend most of my time thinking about food.",
				JournoName = "Merel Blok",
				JournoQuote = "\"The woods are lovely, dark and deep. But I have promises to keep, and miles to go before I sleep. \" - Robert Frost",
				ChairPic = "sophie.jpg",
				JournoPic = "merel.jpg",
				Topic = "The role of services and the support of partners and communities in family planning: what measures should be taken to ensure European women have better control over their sexual and reproductive lives and provide consistent access to basic support and services pertaining to reproductive health?"
			});

			this.Add (new CommitteesItem () {
				Title = "INTA",
				Icon = "inta.jpg",
				Cover = "intal.jpg",
				Overview = "inta.html",
				ChairName = "Alex Narayanin",
				ChairQuote = "My name is Alex, I am half-French, half German and currently live in Berlin. I enjoy Star Wars, puzzling and if I were to be a character of Grey’s Anatomy, I would probably be Richard Webber.",
				JournoName = "Annmarie Kiiskinen",
				JournoQuote = "I once got selected to a session by quoting Grey’s Anatomy phrase “Pick me, choose me, love me” in my application.",
				ChairPic = "alex.jpg",
				JournoPic = "ammi.jpg",
				Topic = "A threat for the acquis communautaire or a quantum leap for economic growth? How should the EU position itself in the next round of Transatlantic Trade and Investment Partnership (TTIP) negotiations?"
			});

			this.Add (new CommitteesItem () {
				Title = "ITRE",
				Icon = "itre.jpg",
				Cover = "itrel.jpg",
				Overview = "itre.html",
				ChairName = "Sofia Zafeiriou",
				ChairQuote = "Student of electrical & computer engineering based in Athens, Greece. Linux enthousiast, oenophile, planning freak. I love good food.",
				JournoName = "Storm Gibbons",
				JournoQuote = "If I was a girl, I would have been called Red, which would have been extremely unfortunate with my surname.",
				ChairPic = "sofia.jpg",
				JournoPic = "storm.jpg",
				Topic = "Improving the hardware and software towards a single European energy market? What further steps should the EU take to ensure all Member States have access to energy that is affordable, competitively priced, secure and environmentally sustain- able?"
			});

			this.Add (new CommitteesItem () {
				Title = "LIBE I",
				Icon = "libei.jpg",
				Cover = "libeil.jpg",
				Overview = "libei.html",
				ChairName = "Albert Reverendo",
				ChairQuote = "Izmir 2015 is a great chance to learn from our contexts and ourselves.We'll ask critically, have fun and develop through academics.",
				JournoName = "Christina Abdulahad",
				JournoQuote = "Merhaba! I'm 20 years old. A happy and sun-loving Swede with Lebanese & Turkish roots. A big fan of new cities, cultures, food & photography.",
				ChairPic = "albert.jpg",
				JournoPic = "christina.jpg",
				Topic = "Pandering to domestic party politics or a genuine concern of European citizens? How should the EU respond to Member States wishing to curtail the right to free movement?"
			});

			this.Add (new CommitteesItem () {
				Title = "LIBE II",
				Icon = "libeii.jpg",
				Cover = "libeiil.jpg",
				Overview = "libeii.html",
				ChairName = "Noura Berrouba",
				ChairQuote = "#selfie #selfiesticks #selfieswithselfiesticks #wefieswithselfiesticks #weselfswithstickysticks #stickselfswithwelfaresticks #workfareonselfiesticks #abandonyourlifegoalstofollowtheselfiemovement #l4l #like4like #summer #sunshine #turk #key #keytoturks #keytolove #life #thestruggleisreal #21stcenturybreakdown #illuminati",
				JournoName = "Dionysis Theodoropoulos",
				JournoQuote = "Citizen of the world longing to live in harmony, to travel, to learn, to grow, to explore, to self-discover and to create; analytical thinker with an insatiable thirst to solve mysteries and puzzles.",
				ChairPic = "noura.jpg",
				JournoPic = "dionysis.jpg",
				Topic = "Je suis Charlie? What measures should the EU take to guarantee the safety of it’s citizens and the protection of basic civil liberties such as the right to freedom of expression and speech, as well as of thought, conscience and religion?"
			});

			this.Add (new CommitteesItem () {
				Title = "LIBE III",
				Icon = "libeiii.jpg",
				Cover = "libeiiil.jpg",
				Overview = "libeiii.html",
				ChairName = "Ilir Kola",
				ChairQuote = "Learning, discussing, challenging yourself and having fun during Izmir are not just important things, they are the only things that matter.",
				JournoName = "Anna Nichols",
				JournoQuote = "Anna comes from a small island on the other side of Europe filled with green fields, corrupt banks and incompetent government officials. This makes it the perfect place to pursue a degree in Law and Political Science, something that she is attempting to do while struggling against fears of being found technologically incompetent.",
				ChairPic = "ilir.jpg",
				JournoPic = "annan.jpg",
				Topic = "How should the EU support companies and citizens in safely gaining access to virtual currencies, given their recent weaknesses to cybercrime?"
			});
		}
	}
}


