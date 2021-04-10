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
    /// Interaction logic for SignUpContent.xaml
    /// </summary>
    public partial class SignUpContent : UserControl
    {
        public SignUpContent()
        {
            InitializeComponent();
            passwordmatchtips.Visibility = Visibility.Hidden;
        }

        private void loginContent_signUpButton_Click1(object sender, RoutedEventArgs e)
        {
            string username = signUpContent_usernameField.Text;
            string password = signUpContent_passwordField1.Password.ToString();
            string passwrd2 = signUpContent_passwordField_2.Password.ToString();

            if (password == passwrd2 && (password != "")) 
            {
  
                globalvariable.currentLoginUsername= username;
                globalvariable.currentLoginUserPassword = password;
                Switcher.SwitchTopPanel(new LoginHeader());
                Switcher.SwitchContentPanel(new LoginContent());
            }
            else
            {
                passwordmatchtips.Visibility = Visibility.Visible;
            }
            //globalvariable.Variable1 = "hello";
            //globalvariable.loginstatus = 1;

            

        }
    }
}
