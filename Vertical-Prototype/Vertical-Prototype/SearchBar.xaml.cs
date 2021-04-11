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
    /// Interaction logic for SearchBar.xaml
    /// </summary>
    public partial class SearchBar : UserControl
    {

        public InitRecipes Init { get; set;}

        public SearchBar()
        {
            InitializeComponent();
        }

        public SearchBar(InitRecipes initObject) : this()
        {
            InitializeComponent();
            this.Init = initObject;
        }

        private void searchBar_addRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            Recipe NewRcp = new Recipe();
            AddRecipeHeader NewHeader = new AddRecipeHeader(NewRcp);
            Switcher.SwitchTopPanel(NewHeader);
            Switcher.SwitchContentPanel(new AddRecipeContent(NewRcp, NewHeader, this.Init));
        }

        private void searchBar_searchButton_Click(object sender, RoutedEventArgs e)
        {
            string[] difficulties;
            if (_difficultyCombo.SelectedIndex == -1 || _difficultyCombo.SelectedIndex == 0)
            {
                difficulties = new string[] { "recipe" };
            } else {
                difficulties = _difficultyCombo.Text.Split(", ");
            }

            string[] cuisunes;
            if (_cuisuneCombo.SelectedIndex == -1 || _cuisuneCombo.SelectedIndex == 0)
            {
                cuisunes = new string[] { "recipe" };
            } else {
                cuisunes = _cuisuneCombo.Text.Split(", ");
            }


            string[] ingredients;
            if (string.IsNullOrEmpty(_ingredientTextbox.Text))
            {
                ingredients = new string[] { "recipe" };
            }
            else
            {
                List<Ingredient> ingList = IngredientSearch.Insearch(this.Init, _ingredientTextbox.Text);
                if (!ingList.Any()) //If the ingredient doesn't match
                {
                    ingredients = new string[] { null };

                } else {
                    ingredients = new string[] { ingList.First().IngredientName };
                    _ingredientTextbox.Text = ingList.First().IngredientName;
                }
                
            }

            string[] tagList = new string[2 + difficulties.Length + cuisunes.Length + ingredients.Length];

            if (_vegetarianCheckbox.IsChecked ?? false)
            {
                tagList[0] = "Vegetarian";
            } else {
                tagList[0] = "recipe";
            }

            if (_veganCheckbox.IsChecked ?? false)
            {
                tagList[1] = "Vegan";
            }
            else
            {
                tagList[1] = "recipe";
            }


            difficulties.CopyTo(tagList, 2);
            cuisunes.CopyTo(tagList, 2 + difficulties.Length);
            ingredients.CopyTo(tagList, 2 + difficulties.Length + cuisunes.Length);



            List<Recipe> filterResults = Search.Searchrecipes(this.Init, tagList);

            List<Recipe> possibleSearches = new List<Recipe>();

            if (string.IsNullOrEmpty(searchBar_textBox.Text))
            {
                possibleSearches = Init.AllRecipes;
            } else {

                foreach (Recipe rcp in this.Init.AllRecipes)
                {
                    string lowerName = rcp.RecipeName.ToLower();
                    if (lowerName.Contains(searchBar_textBox.Text.ToLower()))
                    {
                        possibleSearches.Add(rcp);
                    }
                }
            }

            List<Recipe> searchResults = new List<Recipe>();

            foreach (Recipe rcp in possibleSearches)
            {
                if (filterResults.Contains(rcp))
                {
                    searchResults.Add(rcp);
                }
            }

            Switcher.SwitchContentPanel(new SearchResultsContent(this.Init, searchResults));
            
        }
    }
}
