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
    /// Interaction logic for HomePageContent.xaml
    /// </summary>
    public partial class HomePageContent : UserControl
    {

        public List<Recipe> FeaturedRecipes { get; set; }
        public HomePageContent()
        {

            InitializeComponent();

            this.FeaturedRecipes = new List<Recipe>();

            Recipe rcp1 = new Recipe("TEST");

            //public Recipe(string name, int rate, int diff, string img, int time, List<(Ingredient, int)> ingredients, string instructions)
            List<(Ingredient, double)> aglioIngredinets = new List<(Ingredient, double)>();
            //public Ingredient(string nam, string measurement, int cal, int fat, int carb, int prot)
            aglioIngredinets.Add( (new Ingredient("Spaghetti", "cup(s)", 220, 1.29, 42.95, 8.06), 1) );
            aglioIngredinets.Add( (new Ingredient("Garlic", "clove(s)", 4, 0.02, 0.99, 0.19), 6) );
            aglioIngredinets.Add( (new Ingredient("Olive Oil", "cup(s)", 1909, 216, 0, 0), 0.5) );
            aglioIngredinets.Add( (new Ingredient("Red Pepper Flakes", "tsp(s)", 5, 0.3, 1, 0.2), 0.25) );
            aglioIngredinets.Add( (new Ingredient("Parsley", "cup(s)", 22, 0.47, 3.8, 1.78), 0.25) );
            aglioIngredinets.Add( (new Ingredient("Parmigiano-Reggiano", "oz", 110, 8, 0, 9), 10));
            aglioIngredinets.Add( (new Ingredient("Salt and Papper", "dash", 0,0,0,0), 1) );

            string aglioInstructions = "1. Bring a large pot of lightly salted water to boil. Cook the spaghettin in boiling water, stirring ocasionally until cooked through but still firm to bite (roughly 12 minutes). Drain and transfer into a pasta bowl.\n" +
              "2. Combine garlic and olive oil in a cold skillet. Cook over medium heat to slowly toast the garlic (about 10 minutes). Reduce the heat to medium when olive oil begins to bubble. COok and stir until garlic is golden brown (about 5 minutes).\n" +
              "3. Stir red pepper flakes, black pepper, and salt into the pasta. Pour in olive oil and garlic, and sprinkla on parsley and half of the Parmigiano-Reggiano cheeses; stir until combined.\n" +
              "Serve pasta topped witht eh remaining Parmigiano-Regiano.";

            Recipe aglioEOlio = new Recipe("Pasta Aglio E Olio", 4, 3, "aglioEOlio.png", 30, aglioIngredinets, aglioInstructions);

            
            FeaturedRecipes.Add(aglioEOlio);
            FeaturedRecipes.Add(rcp1);

            RecipeDisplaySmall _displayCard0 = new RecipeDisplaySmall(FeaturedRecipes[0]);
            RecipeDisplaySmall _displayCard1 = new RecipeDisplaySmall(FeaturedRecipes[1]);
            
            innerPanel0.Children.Clear();
            innerPanel0.Children.Add(_displayCard0);

            innerPanel1.Children.Clear();
            innerPanel1.Children.Add(_displayCard1);


        }

        private void panel0Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.SwitchTopPanel(new RecipeHeader(this.FeaturedRecipes[0]));
            Switcher.SwitchContentPanel(new RecipeDisplayContent(this.FeaturedRecipes[0]));
        }
    }
}
