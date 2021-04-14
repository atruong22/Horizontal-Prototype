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
    /// Interaction logic for AddRecipeContent.xaml
    /// </summary>
    public partial class AddRecipeContent : UserControl
    {
        public Recipe NewRecipe { get; set; }

        public InitRecipes Init { get; set; }

        public AddRecipeHeader NewHeader { get; set; }

        public AddRecipeContent()
        {
            InitializeComponent();
        }

        public AddRecipeContent(Recipe NewRcp, AddRecipeHeader header, InitRecipes initObject) : this()
        {
            InitializeComponent();
            this.NewRecipe = NewRcp;
            this.DataContext = this.NewRecipe;
            this.Init = initObject;
            this.NewHeader = header;

            foreach ((Ingredient, double) ingredient in this.NewRecipe.recipeIngredients)
            {
                ingredientTextDisplayEdit ingredientDisplay = new ingredientTextDisplayEdit( this.NewRecipe);
                ingredientDisplay.IngNameTag = ingredient.Item1.IngredientName;
                ingredientDisplay.IngNumTag = ingredient.Item2.ToString();
                ingredientDisplay.IngMeasureTag = ingredient.Item1.BaseMeasure;

                this.IngredientsPanel.Children.Add(ingredientDisplay);
            }
            _recipePhoto.Source = new BitmapImage(new Uri(this.NewRecipe.Image, UriKind.Relative));
         

        }

        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {

            this.NewRecipe.RecipeName = this.NewHeader.AddRecipeHeader_recipeName.Text;
            this.NewRecipe.Instructions = InstructionsTextbox.Text;
            //this.NewRecipe.recipeIngredients

            this.NewRecipe.Difficulty = addRecipeContent_difficultyCombo.SelectedIndex;

            switch(addRecipeContent_prepTimeCombo.SelectedIndex)
            {
                case 0:
                    this.NewRecipe.Time = 10;
                    break;
                case 1:
                    this.NewRecipe.Time = 20;
                    break;
                case 2:
                    this.NewRecipe.Time = 30;
                    break;
                case 3:
                    this.NewRecipe.Time = 45;
                    break;
                case 4:
                    this.NewRecipe.Time = 60;
                    break;
                case 5:
                    this.NewRecipe.Time = 120;
                    break;
                case 6:
                    this.NewRecipe.Time = 125;
                    break;
            }
            //this.NewRecipe.Time = addRecipeContent_prepTimeCombo.SelectedIndex;

            this.Init.UserRecipes.Remove(this.NewRecipe);   //Remove the recipe from the list if it exist
            this.Init.UserRecipes.Add(this.NewRecipe);      //Add / re-add the recipe to My Recipes
            //At the end show a save message

            _saveButtonImage.Source = new BitmapImage(new Uri("/images/savedButton.png", UriKind.Relative));
            System.Timers.Timer timer = new System.Timers.Timer(3000) { Enabled = true };
            timer.Elapsed += (sender, args) =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    _saveButtonImage.Source = new BitmapImage(new Uri("/images/saveButton.png", UriKind.Relative));
                });
            };
        }

        private void addRecipeContent_addIngredientButton_Click(object sender, RoutedEventArgs e)
        {
            AddIngredientStack.Children.Clear();
            AddIngredientStack.Children.Add( new AddIngredientPanel(this.Init, this.NewRecipe, this.NewHeader));
        }

        private void addRecipeContent_addPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            _recipePhoto.Source = new BitmapImage(new Uri("/images/chocolateChipCookies.jpg", UriKind.Relative));
            this.NewRecipe.Image = "images/chocolateChipCookies.jpg";
        }
    }
}
