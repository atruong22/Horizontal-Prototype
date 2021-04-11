using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vertical_Prototype
{
	/// <summary>
	/// Interaction logic for RecipeDisplayContent.xaml
	/// </summary>
	public partial class RecipeDisplayContent : UserControl
	{
		public RecipeDisplayContent()
		{
			InitializeComponent();
		}

		public string customText { get; set; }


		public RecipeDisplayContent(InitRecipes init, Recipe rcp) : this()
		{
			InitializeComponent();
			this.DataContext = rcp;

			if (init.FavoriteRecipes.Contains(rcp))
            {
				_favoriteImage.Source = new BitmapImage( new Uri("/images/unfavoriteButton.png", UriKind.Relative));
            }

			foreach ((Ingredient, double) ingredient in rcp.recipeIngredients)
			{
				ingredientTextDisplay ingredientDisplay = new ingredientTextDisplay();
				ingredientDisplay.IngNameTag = ingredient.Item1.IngredientName;
				ingredientDisplay.IngNumTag = ingredient.Item2.ToString();
				ingredientDisplay.IngMeasureTag = ingredient.Item1.BaseMeasure;

				this.IngredientsPanel.Children.Add(ingredientDisplay);
			}

			recipeDisplayContent_favoriteButton.Click += (sender, eventArgs) =>
			{
				if (init.FavoriteRecipes.Contains(rcp)) //If the recipe is already a favorite and the button is clicked to unfavorite
				{
					_favoriteImage.Source = new BitmapImage(new Uri("/images/favoriteButton.png", UriKind.Relative));
					init.FavoriteRecipes.Remove(rcp);
				} else {	//If the image should be added to favorites
					_favoriteImage.Source = new BitmapImage(new Uri("/images/unfavoriteButton.png", UriKind.Relative));
					init.FavoriteRecipes.Add(rcp);
				}

			};

			_prepTimeLabel.Content = TimeStringFormat.GenerateString(rcp.Time);

		}

	}
}
