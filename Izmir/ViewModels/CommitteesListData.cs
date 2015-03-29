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
				Overview = "afcoi.html",
				ChairName = "Lea Schiewer",
				ChairQuote = "",
				JournoName = "Despina Dimitrakapoulou",
				JournoQuote = "",
				ChairPic = "lea.jpg",
				JournoPic = "despina.jpg",
				Topic = "After almost a decade of accession negotiations and more than 15 years as a Candidate, how should the framework for exploiting the full potential of EU-Turkey relations look like?"
			});

			this.Add (new CommitteesItem () {
				Title = "AFCO II",
				Icon = "afcoii.jpg",
				Overview = "afcoii.html",
				ChairName = "Oscar Stenbom",
				ChairQuote = "I am a really big penis and I like to listen to my hip music, like all the time. Also I like skiing, so much that I went to les deux douches, that was fun. Sometimes I wish I was a professional skiier, then I could fly. Weeeeeeeee.",
				JournoName = "David Soler Crespo",
				JournoQuote = "Sometimes when I laugh really hard, I fart. That can get really awkward sometimes.",
				ChairPic = "oscar.jpg",
				JournoPic = "david.jpg",
				Topic = "How should the EU react to the ever-declining voter turnout in European elections, the low levels of trust in EU institutions and the rise of Eurosceptic parties?"

			});

			this.Add (new CommitteesItem () {
				Title = "AFET I",
				Icon = "afeti.jpg",
				Overview = "afeti.html",
				ChairName = "Oona Kiiskinen",
				ChairQuote = "",
				JournoName = "Egzon Gashi",
				JournoQuote = "",
				ChairPic = "oona.jpg",
				JournoPic = "egzon.jpg",
				Topic = "Crisis at the EU’s Eastern borders? Considering the ongoing violence in Eastern-Ukraine, what role should the EU play in bringing back peace and stability to Ukraine?"
			});

			this.Add (new CommitteesItem () {
				Title = "AFET II",
				Icon = "afetii.jpg",
				Overview = "afetii.html",
				ChairName = "Iuliia Pustovoitova",
				ChairQuote = "",
				JournoName = "Siebe Geerts",
				JournoQuote = "",
				ChairPic = "julia.jpg",
				JournoPic = "siebe.jpg",
				Topic = "With numerous Member States taking part in military actions against the Islamic State in Iraq and the Levant (ISIL) and the European Council calling for a comprehensive strategy to tackle this threat, what measures should the EU take to eradicate violence and bring back stability to the region?"
			});

			this.Add (new CommitteesItem () {
				Title = "AGRI",
				Icon = "agri.jpg",
				Overview = "agri.html",
				ChairName = "Elisa Martinelli",
				ChairQuote = "",
				JournoName = "Flora Böwing",
				JournoQuote = "",
				ChairPic = "elisa.jpg",
				JournoPic = "flora.jpg",
				Topic = "The second pillar of the EU’s Common Agricultural Policy (CAP): In light of the priorities announced for the Rural Development Policy (RDP) for the period 2014-2020, how should the EU endeavour to balance the competitiveness of its agricultural sector, sustainable management of natural resources and the territorial development of rural etconomies?"
			});

			this.Add (new CommitteesItem () {
				Title = "CLIM",
				Icon = "clim.jpg",
				Overview = "clim.html",
				ChairName = "Ciara Robinson",
				ChairQuote = "",
				JournoName = "Cristina Crespo",
				JournoQuote = "",
				ChairPic = "ciara.jpg",
				JournoPic = "cristina.jpg",
				Topic = "The upcoming 2015 United Nations Climate Change Conference in Paris could mark a decisive stage in the negotiations of a post-2020 international agreement on climate change. What role should the EU play in the negotiations of a binding and universal climate agreement?"
			});

			this.Add (new CommitteesItem () {
				Title = "DEVE",
				Icon = "deve.jpg",
				Overview = "deve.html",
				ChairName = "Megan Smith",
				ChairQuote = "",
				JournoName = "Anna Barkemeyer",
				JournoQuote = "",
				ChairPic = "megan.jpg",
				JournoPic = "annab.jpg",
				Topic = "Donor or investor in the fight against poverty? With the European Commission declaring 2015 as the European Year for Development, what role should the EU play in supporting sustainable growth in developing countries?"
			});

			this.Add (new CommitteesItem () {
				Title = "ECON I",
				Icon = "econi.jpg",
				Overview = "econi.html",
				ChairName = "Chris Papadogeorgopoulos",
				ChairQuote = "",
				JournoName = "To be found",
				JournoQuote = "",
				ChairPic = "chris.jpg",
				JournoPic = "example3.jpg",
				Topic = "Evasion versus avoidance? How should Member States address tax avoidance, while respecting their citizens’ right to privacy and Third-Party States’ sovereignty?"
			});

			this.Add (new CommitteesItem () {
				Title = "ECON II",
				Icon = "econii.jpg",
				Overview = "econii.html",
				ChairName = "Mathilde Pascal",
				ChairQuote = "",
				JournoName = "To be found",
				JournoQuote = "",
				ChairPic = "mathilde.jpg",
				JournoPic = "example3.jpg",
				Topic = "With funding for European Small and Medium Enterprises (SMEs) coming primarily from banks and European Commission President Jean-Claude Juncker calling for a better access for SMEs to capital markets; what should the EU do to diversify the sources of funding, and cut the costs of raising capital, for SMEs?"
			});

			this.Add (new CommitteesItem () {
				Title = "FEMM",
				Icon = "femm.jpg",
				Overview = "femm.html",
				ChairName = "Sophie Scannell",
				ChairQuote = "",
				JournoName = "Merel Blok",
				JournoQuote = "",
				ChairPic = "sophie.jpg",
				JournoPic = "merel.jpg",
				Topic = "The role of services and the support of partners and communities in family planning: what measures should be taken to ensure European women have better control over their sexual and reproductive lives and provide consistent access to basic support and services pertaining to reproductive health?"
			});

			this.Add (new CommitteesItem () {
				Title = "INTA",
				Icon = "inta.jpg",
				Overview = "inta.html",
				ChairName = "Alex Narayanin",
				ChairQuote = "",
				JournoName = "Annmarie Kiiskinen",
				JournoQuote = "",
				ChairPic = "alex.jpg",
				JournoPic = "ammi.jpg",
				Topic = "A threat for the acquis communautaire or a quantum leap for economic growth? How should the EU position itself in the next round of Transatlantic Trade and Investment Partnership (TTIP) negotiations?"
			});

			this.Add (new CommitteesItem () {
				Title = "ITRE",
				Icon = "itre.jpg",
				Overview = "itre.html",
				ChairName = "Sofia Zafeiriou",
				ChairQuote = "",
				JournoName = "Storm Gibbons",
				JournoQuote = "",
				ChairPic = "sofia.jpg",
				JournoPic = "storm.jpg",
				Topic = "Improving the hardware and software towards a single European energy market? What further steps should the EU take to ensure all Member States have access to energy that is affordable, competitively priced, secure and environmentally sustain- able?"
			});

			this.Add (new CommitteesItem () {
				Title = "LIBE I",
				Icon = "libei.jpg",
				Overview = "libei.html",
				ChairName = "Albert Reverendo",
				ChairQuote = "",
				JournoName = "Christina Abdulahad",
				JournoQuote = "",
				ChairPic = "albert.jpg",
				JournoPic = "christina.jpg",
				Topic = "Pandering to domestic party politics or a genuine concern of European citizens? How should the EU respond to Member States wishing to curtail the right to free movement?"
			});

			this.Add (new CommitteesItem () {
				Title = "LIBE II",
				Icon = "libeii.jpg",
				Overview = "libeii.html",
				ChairName = "Noura Berrouba",
				ChairQuote = "",
				JournoName = "Dionysis Theodoropoulos",
				JournoQuote = "",
				ChairPic = "noura.jpg",
				JournoPic = "dionysis.jpg",
				Topic = "Je suis Charlie? What measures should the EU take to guarantee the safety of it’s citizens and the protection of basic civil liberties such as the right to freedom of expression and speech, as well as of thought, conscience and religion?"
			});

			this.Add (new CommitteesItem () {
				Title = "LIBE III",
				Icon = "libeiii.jpg",
				Overview = "libeiii.html",
				ChairName = "Ilir Kola",
				ChairQuote = "",
				JournoName = "Anna Nichols",
				JournoQuote = "",
				ChairPic = "ilir.jpg",
				JournoPic = "annan.jpg",
				Topic = "How should the EU support companies and citizens in safely gaining access to virtual currencies, given their recent weaknesses to cybercrime?"
			});

			this.Add (new CommitteesItem () {
				Title = "Other",
				Icon = "example4.jpg",
				ChairName = "",
				ChairQuote = "",
				JournoName = "",
				JournoQuote = "",
				ChairPic = "example2.jpg",
				JournoPic = "example3.jpg",
				Topic = ""
			});
		}
	}
}


