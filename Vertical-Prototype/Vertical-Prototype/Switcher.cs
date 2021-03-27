using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Vertical_Prototype{
    class Switcher
    {
        public static StackPanel topPanel;
        public static StackPanel contentPanel;

        public static void SwitchTopPanel(UserControl newTop)
        {
            topPanel.Children.Clear();
            topPanel.Children.Add(newTop);
        }

        public static void SwitchContentPanel(UserControl newContent)
        {
            contentPanel.Children.Clear();
            contentPanel.Children.Add(newContent);
        }
    }
}
