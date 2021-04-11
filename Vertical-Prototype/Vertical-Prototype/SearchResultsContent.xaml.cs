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
    /// Interaction logic for SearchResultsContent.xaml
    /// </summary>
    public partial class SearchResultsContent : UserControl
    {

        public List<Recipe> DisplayedRecipes { get; set; }

        public InitRecipes Init { get; set; }

        public SearchResultsContent()
        {
            InitializeComponent();
        }

        public SearchResultsContent(InitRecipes init,  List<Recipe> recipeList) : this()
        {

            InitializeComponent();

            this.DisplayedRecipes = recipeList;
            this.Init = init;


            foreach (Recipe rcp in DisplayedRecipes)
            {
                Button btn = new Button();
                btn.Background = Brushes.Transparent;

                RecipeDisplaySmall _displayCard = new RecipeDisplaySmall(rcp);

                btn.Content = _displayCard;
                btn.Click += (sender, eventArgs) =>
                {
                    Switcher.SwitchTopPanel(new RecipeHeader(rcp));
                    Switcher.SwitchContentPanel(new RecipeDisplayContent(this.Init, rcp));
                };

                outerPanel.Children.Add(btn);

            }

        }

    }
}
