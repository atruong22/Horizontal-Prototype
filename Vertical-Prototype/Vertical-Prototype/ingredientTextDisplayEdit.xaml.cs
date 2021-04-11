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
    /// Interaction logic for ingredientTextDisplayEdit.xaml
    /// </summary>
    public partial class ingredientTextDisplayEdit : UserControl
	{

		private string ingNameTag;
		public string IngNameTag
		{
			get { return ingNameTag; }
			set
			{
				ingNameTag = value;
				this.IngredientNameLabel.Content = this.ingNameTag;
			}
		}

		private string ingNumTag;
		public string IngNumTag
		{
			get { return ingNumTag; }
			set
			{
				ingNumTag = value;
				this.IngredientNumLabel.Content = this.ingNumTag;
			}
		}

		private string ingMeasureTag;
		public string IngMeasureTag
		{
			get { return ingMeasureTag; }
			set
			{
				ingMeasureTag = value;
				this.IngredientMeasureLabel.Content = this.ingMeasureTag;
			}
		}

		public Recipe Recipe { get; set; }

		public ingredientTextDisplayEdit(Recipe rcp)
		{
			InitializeComponent();
			this.Recipe = rcp;
		}

        private void _removeIngredientButton_Click(object sender, RoutedEventArgs e)
        {
			(this.Parent as Panel).Children.Remove(this);

		}
    }
}
