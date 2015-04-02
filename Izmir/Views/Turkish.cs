using System;

using Xamarin.Forms;

namespace Izmir
{
	public class Turkish : ContentPage
	{
		public Turkish ()
		{
			Title = "Turkish Dictionary";
			var browser = new BaseUrlWebView () {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			var source = new HtmlWebViewSource ();
			source.Html = @"<!DOCTYPE html>
<html>
<head>
    <link href=""default.css"" rel=""stylesheet"" type=""text/css"">

    <title></title>
</head>

<body class=""single"">
    <div id=""container"">
        <main class=""singlepage"" id=""main"" itemprop=""mainContentOfPage""
        itemscope itemtype=""http://schema.org/Blog"" role=""main"">
            <article class="""">
                <section class=""entry-content cf""><table>
<tr><th></th><th>&nbsp;</th></tr>
 <tr><td><h3><b>Accomodation</b></h3></td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>air-conditioning</td><td>klima</td></tr>
 <tr><td> balcony</td><td>balkon</td></tr>
 <tr><td>entrance</td><td>giri&#351;</td></tr>
 <tr><td>exit</td><td>ç&#305;k&#305;&#351;</td></tr>
 <tr><td>luggage</td><td>bagaj</td></tr>
 <tr><td>reception</td><td>resepsiyon</td></tr>
 <tr><td>restaurant</td><td>restoran / lokanta</td></tr>
 <tr><td>shampoo</td><td>&#351;ampuan</td></tr>
 <tr><td>shower</td><td>du&#351;</td></tr>
 <tr><td>swimming pool</td><td>havuz</td></tr>
 <tr><td>toilet</td><td>tuvalet</td></tr>
 <tr><td>towel</td><td>havlu</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td><h3><b>Transportation</b><h3></td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>airport</td><td>havaliman&#305;</td></tr>
 <tr><td>bus / coach</td><td>otobüs</td></tr>
 <tr><td>fare</td><td>ücret</td></tr>
 <tr><td>map</td><td>harita</td></tr>
 <tr><td>passenger</td><td>yolcu</td></tr>
 <tr><td>plane</td><td>uçak</td></tr>
 <tr><td>subway / underground</td><td>metro</td></tr>
 <tr><td>taxi</td><td>taksi</td></tr>
 <tr><td>ticket</td><td>bilet</td></tr>
 <tr><td>timetable</td><td>tarife</td></tr>
 <tr><td>train</td><td>tren</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td><h3><b>Food and Drink</b></h3></td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>beer</td><td>bira</td></tr>
 <tr><td>black pepper</td><td>karabiber</td></tr>
 <tr><td>bottle</td><td>&#351;i&#351;e</td></tr>
 <tr><td>bread</td><td>ekmek</td></tr>
 <tr><td>breakfast</td><td>kahvalt&#305;</td></tr>
 <tr><td>dessert</td><td>tatl&#305;</td></tr>
 <tr><td>dinner</td><td>ak&#351;am yeme&#287;i</td></tr>
 <tr><td>enjoy your meal</td><td>afiyet olsun</td></tr>
 <tr><td>fillet steak</td><td>bonfile</td></tr>
 <tr><td>fish</td><td>bal&#305;k</td></tr>
 <tr><td>food</td><td>yemek</td></tr>
 <tr><td>fork</td><td>çatal</td></tr>
 <tr><td>knife</td><td>b&#305;çak</td></tr>
 <tr><td>lunch</td><td>ö&#287;le yeme&#287;i</td></tr>
 <tr><td>main course</td><td>ana yemek</td></tr>
 <tr><td>meat</td><td>et</td></tr>
 <tr><td>menu</td><td>menü</td></tr>
 <tr><td>salt</td><td>tuz</td></tr>
 <tr><td>spoon</td><td>ka&#351;&#305;k</td></tr>
 <tr><td>starter</td><td>meze</td></tr>
 <tr><td>table</td><td>masa</td></tr>
 <tr><td>waiter / waitress</td><td>garson</td></tr>
 <tr><td>water</td><td>su</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td><h3><b>Small Talk</b></h3></td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>good morning</td><td>günayd&#305;n</td></tr>
 <tr><td>good night</td><td>iyi geceler</td></tr>
 <tr><td>goodbye</td><td>ho&#351;ça kal&#305;n or bye bye</td></tr>
 <tr><td>hello</td><td>merhaba</td></tr>
 <tr><td>How many?</td><td>Kaç tane?</td></tr>
 <tr><td>How much? (price)</td><td>Kaç para?</td></tr>
 <tr><td>no</td><td>hay&#305;r</td></tr>
 <tr><td>ok</td><td>tamam</td></tr>
 <tr><td>please</td><td>lütfen</td></tr>
 <tr><td>sorry / excuse me</td><td>pardon / affedersiniz</td></tr>
 <tr><td>thank you</td><td>mersi</td></tr>
 <tr><td>yes</td><td>evet</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td><h3><b>Directions</b></h3></td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>broken</td><td>bozuk</td></tr>
 <tr><td>down</td><td>a&#351;a&#287;&#305;</td></tr>
 <tr><td>far</td><td>uzak</td></tr>
 <tr><td>here</td><td>burada</td></tr>
 <tr><td>left</td><td>sol</td></tr>
 <tr><td>near</td><td>yak&#305;n</td></tr>
 <tr><td>right</td><td>sa&#287;</td></tr>
 <tr><td>straight on</td><td>do&#287;ru</td></tr>
 <tr><td>there</td><td>orada</td></tr>
 <tr><td>up</td><td>yukar&#305;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td><h3><b>In Case of Emergency</b><h3></td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>accident</td><td>kaza</td></tr>
 <tr><td>Call an ambulance!</td><td>Ambulans ça&#287;r&#305;n!</td></tr>
 <tr><td>Call the police!</td><td>Polis ça&#287;r&#305;n!</td></tr>
 <tr><td>dentist</td><td>di&#351; hekimi</td></tr>
 <tr><td>doctor</td><td>doktor</td></tr>
 <tr><td>Fire!</td><td>Yang&#305;n!</td></tr>
 <tr><td>Help!</td><td>&#304;mdat!</td></tr>
 <tr><td>hospital</td><td>hastane</td></tr>
 <tr><td>pain</td><td>a&#287;r&#305;</td></tr>
 <tr><td>pharmacy</td><td>ezcane</td></tr>
 <tr><td>police</td><td>polis</td></tr>
 <tr><td>sick / ill</td><td>hasta</td></tr>
 <tr><td>Stop!</td><td>Dur!</td></tr>
 <tr><td>Where is the nearest hospital?</td><td>En yak&#305;n hastane nerede?</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td><h3><b>Prompts</b></h3></td><td>&nbsp;</td></tr>
 <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
 <tr><td>Can I have?</td><td>rica ediyorum.</td></tr>
 <tr><td>Can you help me? (in a shop)</td><td>Bakar m&#305;s&#305;n&#305;z?</td></tr>
 <tr><td>Can you help me?</td><td>Bana yard&#305;m edebilir misiniz?</td></tr>
 <tr><td>Do you speak English?</td><td>&#304;ngilizce konu&#351;uyor musunuz?</td></tr>
 <tr><td>Excellent!</td><td>Çok güzel!</td></tr>
 <tr><td>I can’t speak Turkish.</td><td>Türkçe bilmiyorum.</td></tr>
 <tr><td>I don’t understand.</td><td>Anlam&#305;yorum.</td></tr>
 <tr><td>I would like</td><td>istiyorum.</td></tr>
 <tr><td>What time is it?</td><td>Saat kaç?</td></tr>
 <tr><td>Where is the toilet?</td><td>Tuvalet nerede?</td></tr>
 <tr><td>Where can I get?</td><td>nerede bulabilirim?</td></tr>
 <tr><td>Where do I pay?</td><td>Kasa nerede?</td></tr>
 <tr><td>Where is/are?</td><td>nerede?</td></tr>
</table>
</section></article></main></div></body>";
			if (Device.OS != TargetPlatform.iOS) {
				// the BaseUrlWebViewRenderer does this for iOS, until bug is fixed
				source.BaseUrl = DependencyService.Get<IBaseUrl> ().Get ();
			}
			browser.Source = source;

			this.Content = browser;
		}
	}
}


