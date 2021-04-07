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


		public RecipeDisplayContent(Recipe rcp) : this()
		{
			InitializeComponent();
			this.DataContext = rcp;

			foreach ((Ingredient, double) ingredient in rcp.recipeIngredients)
			{
				ingredientTextDisplay ingredientDisplay = new ingredientTextDisplay();
				ingredientDisplay.IngNameTag = ingredient.Item1.IngredientName;
				ingredientDisplay.IngNumTag = ingredient.Item2.ToString();
				ingredientDisplay.IngMeasureTag = ingredient.Item1.BaseMeasure;

				this.IngredientsPanel.Children.Add(ingredientDisplay);
			}

		}

        private void recipeDisplayContent_rateButton_Click(object sender, RoutedEventArgs e)
        {
			Rating_WPF.MainWindow ratingView = new Rating_WPF.MainWindow();
			ratingView.Show();
        }
    }
}
