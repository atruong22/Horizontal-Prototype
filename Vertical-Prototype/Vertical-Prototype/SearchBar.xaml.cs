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
    }
}
