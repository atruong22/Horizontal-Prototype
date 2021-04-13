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
    /// Interaction logic for HelpContent.xaml
    /// </summary>
    public partial class HelpContent : UserControl
    {
        public HelpContent()
        {
            InitializeComponent();



            Label lb1 = new Label();
            lb1.Content = "Navigation";
            lb1.FontWeight = FontWeights.Bold;
            outerPanel.Children.Add(lb1);

            TextBlock tb1 = new TextBlock();
            tb1.Width = 600;
            tb1.TextWrapping = TextWrapping.Wrap;
            tb1.Text = "The navigation bar on the left side of the screen is accessible from anywhere in the application. To view the Home Page and view our featured recipes click on the chef hat logo in the top left of the screen. A collection of your own recipes can be found by clicking on the “My Recipes” button. Any recipes you have favorited are located in the “Favorites” page. To login or create an account to keep track of your recipes, click on the “Login” button. The search bar at the top of this page can be used to search for specific recipes by name by typing into the large textbox and clicking on the magnifying glass icon. The results for your search can be filtered out by difficulty, cuisine, key ingredients, and if they are vegetarian or vegan by selecting the appropriate fields before searching. If the textbox is left empty your search will return all recipes that fit the criteria of your filters and can be browsed by scrolling through them. In the top right corner of the screen, there is a button labeled “Add Recipe” that you can use to add any recipe you want into the application.";

            Thickness margin = tb1.Margin;
            margin.Bottom = 30;
            tb1.Margin = margin;

            outerPanel.Children.Add(tb1);

            Label lb2 = new Label();
            lb2.Content = "Adding a Recipe of your own";
            lb2.FontWeight = FontWeights.Bold;
            outerPanel.Children.Add(lb2);

            TextBlock tb2 = new TextBlock();
            tb2.Width = 600;
            tb2.TextWrapping = TextWrapping.Wrap;
            tb2.Text = "By clicking on the “Add Recipe” button in the top right corner of the screen, you will be brought to a new screen where you can enter the information for the recipe. To add a recipe, start by giving a name to the recipe in the textbox at the top of the screen. Then select its difficulty and the time it takes to prepare. Then, you can add ingredients to the recipe one at a time by searching for it by name and selecting how much of that ingredient to add. Additionally, you can add instructions to help you remember how to prepare the recipe. Finally, click the button labeled “Save” to have your recipe saved into your “My Recipes” page.";

            tb2.Margin = margin;

            outerPanel.Children.Add(tb2);

            Button btn = new Button();
            btn.Content = "reset password";
            btn.Width = 200;
            outerPanel.Children.Add(btn);
        }
    }
}
