using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertical_Prototype
{
    public class Ingredient
    {
        public string  IngredientName { get; set;}

        public string BaseMeasure { get; set;}
        //The measurement for one serving of the ingredient

        public double Calories { get; set;}

        //Fat, protein and carbs are all in grams
        public double Fat { get; set;}

        public double Protein { get; set;}

        public double Carbohydrates { get; set;}

        public Ingredient(string nam, string measurement, double cal, double fat, double carb, double prot)
        {
            this.IngredientName = nam;
            this.BaseMeasure = measurement;
            this.Calories = cal;
            this.Fat = fat;
            this.Protein = prot;
            this.Carbohydrates = carb;
        }

    }
}
