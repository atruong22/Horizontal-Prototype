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
    /// Interaction logic for AddIngredientPanel.xaml
    /// </summary>
    public partial class AddIngredientPanel : UserControl
    {
        private List<Ingredient> ingredients;

        private Recipe RecipeForIngredient;

        private Ingredient selectedIngredient;

        private AddRecipeHeader header;

        private InitRecipes Init;
        public AddIngredientPanel()
        {
            InitializeComponent();
        }

        public AddIngredientPanel(InitRecipes init, Recipe rcp, AddRecipeHeader hdr) : this()
        {
            InitializeComponent();
            this.RecipeForIngredient = rcp;
            this.Init = init;
            this.ingredients = new List<Ingredient>();
            this.header = hdr;

        }

        private void SaveIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (this.selectedIngredient != null && !string.IsNullOrEmpty(numServingsTextbox.Text))
            {
                try
                {
                    double quantity = Convert.ToDouble(numServingsTextbox.Text);
                    //Add to the recipe
                    this.RecipeForIngredient.AddIngredient(this.selectedIngredient, quantity);

                    //Close the window
                    (this.Parent as Panel).Children.Remove(this);

                    //Update Page
                    Switcher.SwitchContentPanel(new AddRecipeContent(this.RecipeForIngredient, this.header, this.Init));

                } catch (FormatException) {
                    //The quantity entered is not a bouble
                }
            }
            //TODO: Save the ingredient to the recipe based on the fields.
        }

        //The X button to clear the pannel
        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void searchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                listOfIngredientsStack.Children.Clear();

                this.ingredients = IngredientSearch.Insearch(Init, searchTextbox.Text);
                foreach (Ingredient ing in this.ingredients)
                {
                    Button btn = new Button();
                    Label lbl = new Label();
                    lbl.Content = ing.IngredientName;
                    btn.Content = lbl;
                    btn.Click += (sender, eventArgs) =>
                    {
                        this.selectedIngredient = ing;
                        servingSizeLabel.Content = "1 " + ing.BaseMeasure;
                    };

                    listOfIngredientsStack.Children.Add(btn);
                }
            }
        }
    }
}
