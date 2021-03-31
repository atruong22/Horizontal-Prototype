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
        //Initialize all the pages
        SearchBar _searchBar = new SearchBar();
        LoginHeader _loginHeader = new LoginHeader();
        SignUpHeader _signUpHeader = new SignUpHeader();

        HomePageContent _homePageContent = new HomePageContent();
        FavoriteRecipesContent _favoriteRecipesContent = new FavoriteRecipesContent();
        MyRecipesContent _myRecipesContent = new MyRecipesContent();
        LoginContent _loginContent = new LoginContent();
        SignUpContent _signUpContent = new SignUpContent();


        public MainWindow()
        {
            InitializeComponent();

            //Pass the panels to the switcher
            Switcher.topPanel = this.topPanel;
            Switcher.contentPanel = this.contentPanel;

            Switcher.SwitchTopPanel(_searchBar);
            Switcher.SwitchContentPanel(_homePageContent);
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        private void mainWindow_homeButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.SwitchTopPanel(_searchBar);
            Switcher.SwitchContentPanel(_homePageContent);
        }

        private void mainWindow_favoritesButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.SwitchTopPanel(_searchBar);
            Switcher.SwitchContentPanel(_favoriteRecipesContent);

        }

        private void mainWindow_myRecipesButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.SwitchTopPanel(_searchBar);
            Switcher.SwitchContentPanel(_myRecipesContent);
        }

        private void mainWindow_loginButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.SwitchTopPanel(_loginHeader);
            Switcher.SwitchContentPanel(_loginContent);
        }
    }
}
