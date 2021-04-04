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
        }

        public HomePageContent(List<Recipe> recipeList) : this()
        {

            InitializeComponent();

            this.FeaturedRecipes = recipeList;


            foreach (Recipe rcp in FeaturedRecipes){
                Button btn = new Button();
                btn.Background = Brushes.Transparent;

                RecipeDisplaySmall _displayCard = new RecipeDisplaySmall(rcp);

                btn.Content = _displayCard;
                btn.Click += (sender, eventArgs) =>
                    {
                        Switcher.SwitchTopPanel(new RecipeHeader(rcp));
                        Switcher.SwitchContentPanel(new RecipeDisplayContent(rcp));
                    };

                outerPanel.Children.Add(btn);

            }

        }

    }
}
