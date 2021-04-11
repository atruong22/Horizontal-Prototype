using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertical_Prototype
{
	public class Recipe
	{
		public string RecipeName { get; set;}

		public float Rating { get; set; }

		public string PrintRating { get; set; }

		public int NumRating { get; set; }

		public int TotalRating { get; set; }

		public int Difficulty { get; set; }
		//Difficulty from 0-3; easy, medium, hard, expert

		public int Time { get; set; }
		//In minutes

		public string Image { get; set; }
		//The path of the recipe image

		public List<(Ingredient, double)> recipeIngredients;
		//A list of tupples containing ingredients and their servings
		//Use recipeIngredents.Count to find the number of ingredients

		public string[] tags { get; set; }
		//list containing tags for searching and filtering

		public string Instructions { get; set; }
		//Instructions to make the recipe. One long string that can use \n to separate steps

		public void AddIngredient(Ingredient ing, double servings)
		{
			recipeIngredients.Add((ing, servings));
		}

		public void RemoveIngredient(Ingredient ing, int servings)
		{
			recipeIngredients.Remove((ing, servings));
		}


		public double Calories
		{
			get
			{
				double sum = 0;

				foreach ( (Ingredient, double) ingredient in this.recipeIngredients )
				{
					sum += ingredient.Item1.Calories * ingredient.Item2;
				}
				return Math.Round(sum);
			}
		}

		public double Fat
		{
			get
			{
				double sum = 0;

				foreach ((Ingredient, double) ingredient in this.recipeIngredients)
				{
					sum += ingredient.Item1.Fat * ingredient.Item2;
				}
				return Math.Round(sum);
			}
		}

		public double Protein
		{
			get
			{
				double sum = 0;

				foreach ((Ingredient, double) ingredient in this.recipeIngredients)
				{
					sum += ingredient.Item1.Protein * ingredient.Item2;
				}
				return Math.Round(sum);
			}
		}

		public double Carbohydrates
		{
			get
			{
				double sum = 0;

				foreach ((Ingredient, double) ingredient in this.recipeIngredients)
				{
					sum += ingredient.Item1.Carbohydrates * ingredient.Item2;
				}
				return Math.Round(sum);
			}
		}

		//The constructor that will be called when users create a new recipe
		public Recipe()
		{
			this.RecipeName = "Give your recipe a name!";
			this.Rating = 0;
			this.Difficulty = 0;
			this.Image = "/images/AddImage.png";
			this.Time = 10;
			this.Instructions = "Here is where you can describe the steps to prepair your dish.\n" +
				"The entire contents of this textbox will be saved as part of your recipe." +
				"Consider numbering the steps in your recipe, but the decision is all up to you.\n" +
				"Theis box is for you to use as you like!";
			this.recipeIngredients = new List<(Ingredient, double)>();
			this.tags =  new string[] { "recipe"};
		}

		//The constructor used to specify predefined recipes
		public Recipe(string name, int rate, int diff, string img, int time, List<(Ingredient, double)> ingredients, string instructions)
		{

			this.NumRating = 1;
			this.TotalRating = rate;
			this.RecipeName = name;
			this.Rating = rate;
			this.PrintRating = Rating.ToString("0.0");
			this.Difficulty = diff;
			this.Time = time;
			this.Instructions =instructions;
			this.Image = "/images/" + img;
			this.recipeIngredients = ingredients;
			this.Instructions = instructions;
		}

		public Recipe(string nam)
		{
			this.RecipeName = nam;
			this.Rating = 3;
			this.Difficulty = 3;
			this.Time = 15;
			this.Instructions = "Instructions I guess.........";
			this.Image = "/images/aglioEOlio.png";
		}


		public float AddNewRating(int rate)
		{
			this.TotalRating += rate;
			this.NumRating++;
			this.Rating = (float)TotalRating / (float)NumRating;
			this.PrintRating = Rating.ToString("0.0");
			return Rating;
		}
	}
}
