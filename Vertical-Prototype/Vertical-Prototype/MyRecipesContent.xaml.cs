﻿using System;
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
	/// Interaction logic for MyRecipesContent.xaml
	/// </summary>
	public partial class MyRecipesContent : UserControl
	{
		//public List<Recipe> MyRecipes { get; set; }

        public InitRecipes Init { get; set; }

		public MyRecipesContent()
		{
			InitializeComponent();
		}

        public MyRecipesContent(InitRecipes init) : this()
        {

            InitializeComponent();

            this.Init = init;


            foreach (Recipe rcp in this.Init.UserRecipes)
            {
                Button btn = new Button();
                btn.Background = Brushes.Transparent;

                MyRecipeDisplaySmall _displayCard = new MyRecipeDisplaySmall(rcp, this.Init);

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
