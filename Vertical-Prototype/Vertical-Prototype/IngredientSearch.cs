using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//things needed to be done
//1.create a string variable containing user typed keyword in ingredient search bar
//2.display list of ingredients in stack panel
namespace Vertical_Prototype
{
  class IngredientSearch
	{

	//ingredientsearch takes a string which is a user typed input for ingredient searching
	public static List<Ingredient> Insearch(InitRecipes init, string keyword)
		{
		//create a variable for storing searched ingredients
		List<Ingredient> searchresult = new List<Ingredient>();

		//check every ingredients in the system
		foreach (Ingredient ing in init.AllIngredients)
			{

			//if ingredient name contains the user typed keyword, add it to the searchresult
			string lowerIngredientName = ing.IngredientName.ToLower();
			if (lowerIngredientName.Contains(keyword.ToLower()))
				{
					searchresult.Add(ing);
				}
			}
		//after checking every ingredients, return the searchresult as list of ingredients
		return searchresult;
		}
	}
}