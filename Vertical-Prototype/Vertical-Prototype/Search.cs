using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//things needed to be done
//1.generate list of string containing user input in search bar and user selected filtering field.
//2.display list of recipes in search result page
namespace Vertical_Prototype
{
  class Search
	{
		//search function takes list of strings containing all keywords used for searching and filtering
		public static List<Recipe> Searchrecipes(InitRecipes init, string[] keywords)
        {
	  //create a varoable for storing searched and filtered recipes
	  List<Recipe> searchresult = new List<Recipe>();

			//check every recipes, one at each iteration
			foreach (Recipe rcp in init.AllRecipes)
			{
			//create a variable for storing recipe's tags
			string[] taglist = rcp.tags;

			//call containseverything function to see if this recipe has all the keywords that user want from searching and filtering
			if (Search.Containseverything(taglist, keywords))
				{
					//if this recipe contains all the keywordss, add it to the searchresult
					searchresult.Add(rcp);
				}
			}
	  //return search result as an output
	  return searchresult;
		}

	//containseverything function takes recipetags which is a list of strings containing tags of recipe
	//and keywords which is a list of strings containing keywords for searching and filtering
	public static bool Containseverything(string[] recipetags, string[] keywords)
		{
		//check every keyword in keywords
		for (int i = 0; i < keywords.Length; i++)
			{
		//if recipe does not contain the keyword, retrun false
		if (recipetags.Contains(keywords[i]) == false)
				{
					return false;
				}
				//if recipe contains the keyword, continue to next iteration for checking the next keyword.
				else
				{
					continue;
				}
			}
	  //if loop succesfully terminate, it means that recipe contains all the keywords in its tags
	  //therefore, return true
	  return true;
		}
	}
}