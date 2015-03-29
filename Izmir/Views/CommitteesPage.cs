using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Izmir
{
	public class CommitteesPage : ContentPage
	{
		public CommitteesPage ()
		{
			Title = "Committees";

			Command navigateCommand = 
				new Command(async (obj) => 
					{
						var compage = new CommitteePage(obj as CommitteesItem);
						await Navigation.PushAsync(compage);
					});
			
			Grid grid = new Grid {
				VerticalOptions = LayoutOptions.FillAndExpand,
				ColumnSpacing = 0,
				RowSpacing = 0,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) },
					new RowDefinition { Height = new GridLength(130, GridUnitType.Absolute) }
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
				}
			};

			List<CommitteesItem> data = new CommitteesListData ();

			int i = 0;
			int b = 0;
			int c = -1;

			foreach (CommitteesItem com in data) {
				
				if ((i % 2) == 0) {
					b = 0;
					c++;
				} else {
					b = 1;
				};

				var titleButton = new Button () {
					Text = com.Title,
					TextColor = Color.White,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.Transparent,
					FontSize = 24,
					Command = navigateCommand,
					CommandParameter = com
				};

				var iconImage = new Image () {
					Source = ImageSource.FromFile(com.Icon),
					Aspect = Aspect.AspectFill
				};

				RelativeLayout comlayout = new RelativeLayout ();

				comlayout.Children.Add (iconImage,
					Constraint.Constant (0),
					Constraint.Constant (0),
					Constraint.RelativeToParent ((parent) => { return parent.Width; }),
					Constraint.RelativeToParent ((parent) => { return parent.Height; }));

				comlayout.Children.Add (titleButton,
					Constraint.Constant (0),
					Constraint.Constant (0),
					Constraint.RelativeToParent ((parent) => { return parent.Width; }),
					Constraint.RelativeToParent ((parent) => { return parent.Height; }));

				grid.Children.Add (comlayout, b, c);

				i++;
			};

			ScrollView comscroll = new ScrollView () {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = grid
			};
			this.Content = comscroll;

		}
	}
}


