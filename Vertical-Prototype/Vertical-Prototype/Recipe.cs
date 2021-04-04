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
	 
		public int Rating { get; set; }

		public int Difficulty { get; set; }
		//Difficulty from 0-3; easy, medium, hard, expert

		public int Time { get; set; }
		//In minutes

		public string Image { get; set; }
		//The path of the recipe image

		public List<(Ingredient, double)> recipeIngredients;
		//A list of tupples containing ingredients and their servings
		//Use recipeIngredents.Count to find the number of ingredients

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


		public Recipe()
		{
			this.RecipeName = "Test";
			this.Rating = 3;
			this.Difficulty = 3;
			this.Time = 15;
			this.Instructions = "Instructions I guess.........";
			this.recipeIngredients = new List<(Ingredient, double)>();
		}

		public Recipe(string name, int rate, int diff, string img, int time, List<(Ingredient, double)> ingredients, string instructions)
		{
			this.RecipeName = name;
			this.Rating = rate;
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

	}
}
