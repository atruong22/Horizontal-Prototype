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

        private Recipe RecipeForIngredient;
        public AddIngredientPanel()
        {
            InitializeComponent();
        }

        public AddIngredientPanel(Recipe rcp) : this()
        {
            InitializeComponent();
            this.RecipeForIngredient = rcp;

        }

        private void SaveIngredient_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Save the ingredient to the recipe based on the fields.
        }

        //The X button to clear the pannel
        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
