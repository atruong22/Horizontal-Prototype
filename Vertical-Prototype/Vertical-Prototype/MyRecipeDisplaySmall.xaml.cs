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
    /// Interaction logic for MyRecipeDisplaySmall.xaml
    /// </summary>
    public partial class MyRecipeDisplaySmall : UserControl
    {
        public Recipe MyRecipe { get; set; }

        public InitRecipes Init { get; set; }

        public MyRecipeDisplaySmall()
        {
            InitializeComponent();
        }


        public MyRecipeDisplaySmall(Recipe rcp, InitRecipes init) : this()
        {
            InitializeComponent();
            this.MyRecipe = rcp;
            this.DataContext = this.MyRecipe;
            this.Init = init;
            _prepTimeText.Content = TimeStringFormat.GenerateString(this.MyRecipe.Time);

            switch (rcp.Difficulty)
            {
                case 3:
                    _difficultyImage.Source = new BitmapImage(new Uri("/images/expertDifficulty.png", UriKind.Relative));
                    break;
                case 2:
                    _difficultyImage.Source = new BitmapImage(new Uri("/images/hardDifficulty.png", UriKind.Relative));
                    break;
                case 1:
                    _difficultyImage.Source = new BitmapImage(new Uri("/images/mediumDifficulty.png", UriKind.Relative));
                    break;
                default:
                    _difficultyImage.Source = new BitmapImage(new Uri("/images/easyDifficulty.png", UriKind.Relative));
                    break;
            }
        }

        private void MyRecipeEditButon_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            AddRecipeHeader NewHeader = new AddRecipeHeader(this.MyRecipe);
            Switcher.SwitchTopPanel(NewHeader);
            Switcher.SwitchContentPanel(new AddRecipeContent(MyRecipe, NewHeader, this.Init));
        }
    }
}
