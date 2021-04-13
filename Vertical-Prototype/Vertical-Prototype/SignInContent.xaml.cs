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
    /// Interaction logic for SignInContent.xaml
    /// </summary>
    public partial class SignInContent : UserControl
    {
        public InitRecipes Init { get; set; }
        public SignInContent(InitRecipes init)
        {
            InitializeComponent();
            this.Init = init;
            Username.Text = globalvariable.currentLoginUsername;
            _numCreated.Text = this.Init.UserRecipes.Count().ToString();
            _numFavorites.Text = this.Init.FavoriteRecipes.Count().ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            globalvariable.loginstatus = 0;
            Switcher.SwitchTopPanel(new LoginHeader());
            Switcher.SwitchContentPanel(new LoginContent(this.Init));
        }
    }
}
