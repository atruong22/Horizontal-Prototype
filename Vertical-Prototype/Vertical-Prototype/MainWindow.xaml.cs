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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public InitRecipes Init { get; set; }

        //Initialize all the pages

        LoginHeader _loginHeader = new LoginHeader();

        LoginContent _loginContent = new LoginContent();


        public MainWindow()
        {
            InitializeComponent();
            globalvariable.loginstatus = 0;

            this.Init = new InitRecipes();

            //Pass the panels to the switcher
            Switcher.topPanel = this.topPanel;
            Switcher.contentPanel = this.contentPanel;

            Switcher.SwitchTopPanel(new SearchBar(this.Init));
            Switcher.SwitchContentPanel(new HomePageContent(this.Init, this.Init.FeaturedRecipes));
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void mainWindow_homeButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.SwitchTopPanel(new SearchBar(this.Init));
            Switcher.SwitchContentPanel(new HomePageContent(this.Init, this.Init.FeaturedRecipes));
        }

        private void mainWindow_favoritesButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.SwitchTopPanel(new SearchBar(this.Init));
            if (globalvariable.loginstatus == 0)
            {
                Switcher.SwitchContentPanel(new LoginInTips());
            }
            else
            {
                Switcher.SwitchContentPanel(new FavoriteRecipesContent(this.Init, this.Init.FavoriteRecipes));
            }
            

        }

        private void mainWindow_myRecipesButton_Click(object sender, RoutedEventArgs e)
        {

            Switcher.SwitchTopPanel(new SearchBar(this.Init));
            if (globalvariable.loginstatus == 0)
            {
                Switcher.SwitchContentPanel(new LoginInTips());
            }
            else
            {
                Switcher.SwitchContentPanel(new MyRecipesContent(this.Init));
            }

        }

        private void mainWindow_loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (globalvariable.loginstatus == 0)
            {
                Switcher.SwitchTopPanel(new LoginHeader());
                Switcher.SwitchContentPanel(new LoginContent());
            }
            else
            {
                Switcher.SwitchTopPanel(new SignInHeader());
                Switcher.SwitchContentPanel(new SignInContent());
            }
        }
    }
}
