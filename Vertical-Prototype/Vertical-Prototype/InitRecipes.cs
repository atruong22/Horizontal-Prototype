using System.Collections.Generic;

namespace Vertical_Prototype
{
    public class InitRecipes
    {
        public List<Recipe> AllRecipes { get; set; }

        public List<Ingredient> AllIngredients { get; set; }

        public List<Recipe> FeaturedRecipes { get; set; }

        public List<Recipe> FavoriteRecipes { get; set; }

        public List<Recipe> UserRecipes { get; set; }

        public InitRecipes()
        {

            this.AllRecipes = new List<Recipe>();
            this.AllIngredients = new List<Ingredient>();
            this.FeaturedRecipes = new List<Recipe>();
            this.FavoriteRecipes = new List<Recipe>();
            this.UserRecipes = new List<Recipe>();

            //Cookie ingredients for demo
            this.AllIngredients.Add(new Ingredient("Butter", "cup(s)", 1628, 184.12, 0.14, 1.93));
            this.AllIngredients.Add(new Ingredient("White Sugar", "cup(s)", 774, 0, 199.96, 0));
            //this.AllIngredients.Add(new Ingredient("Brown Sugar", "cup(s)", 547, 0, 141.13, 0));
            this.AllIngredients.Add(new Ingredient("Eggs", "", 74, 4.97, 0.38, 6.29));
            this.AllIngredients.Add(new Ingredient("Vanilla Extract", "tsp", 12, 0, 0.53, 0));
            this.AllIngredients.Add(new Ingredient("Baking soda", "tsp", 0, 0, 0, 0));
            this.AllIngredients.Add(new Ingredient("Water", "cup(s)", 0, 0, 0, 0));
            this.AllIngredients.Add(new Ingredient("Salt", "tsp", 0, 0, 0, 0));
            this.AllIngredients.Add(new Ingredient("All-Purpose Flour", "cup(s)", 400, 0, 88, 12));
            this.AllIngredients.Add(new Ingredient("Chocolate Chips", "cup(s)", 16 * 70, 16 * 4, 160, 16));


            //Aglio
            //public Recipe(string name, int rate, int diff, string img, int time, List<(Ingredient, int)> ingredients, string instructions)
            List<(Ingredient, double)> aglioIngredinets = new List<(Ingredient, double)>();
            //public Ingredient(string nam, string measurement, int cal, int fat, int carb, int prot)
            aglioIngredinets.Add((new Ingredient("Spaghetti", "cup(s)", 220, 1.29, 42.95, 8.06), 1));
            this.AllIngredients.Add(new Ingredient("Spaghetti", "cup(s)", 220, 1.29, 42.95, 8.06));

            //For testing
            //this.AllIngredients.Add(new Ingredient("Spagooter", "cup(s)", 220, 1.29, 42.95, 8.06));
            //this.AllIngredients.Add(new Ingredient("Spagootini", "cup(s)", 220, 1.29, 42.95, 8.06));
            //this.AllIngredients.Add(new Ingredient("Spaggy", "cup(s)", 220, 1.29, 42.95, 8.06));
            //this.AllIngredients.Add(new Ingredient("Spaginator", "cup(s)", 220, 1.29, 42.95, 8.06));
            //this.AllIngredients.Add(new Ingredient("Spagizzle", "cup(s)", 220, 1.29, 42.95, 8.06));

            aglioIngredinets.Add((new Ingredient("Garlic", "clove(s)", 4, 0.02, 0.99, 0.19), 6));
            this.AllIngredients.Add(new Ingredient("Garlic", "clove(s)", 4, 0.02, 0.99, 0.19));

            aglioIngredinets.Add((new Ingredient("Olive Oil", "cup(s)", 1909, 216, 0, 0), 0.5));
            this.AllIngredients.Add(new Ingredient("Olive Oil", "cup(s)", 1909, 216, 0, 0));

            aglioIngredinets.Add((new Ingredient("Red Pepper Flakes", "tsp(s)", 5, 0.3, 1, 0.2), 0.25));
            this.AllIngredients.Add(new Ingredient("Red Pepper Flakes", "tsp(s)", 5, 0.3, 1, 0.2));

            aglioIngredinets.Add((new Ingredient("Parsley", "cup(s)", 22, 0.47, 3.8, 1.78), 0.25));
            this.AllIngredients.Add(new Ingredient("Parsley", "cup(s)", 22, 0.47, 3.8, 1.78));

            aglioIngredinets.Add((new Ingredient("Parmigiano-Reggiano", "oz", 110, 8, 0, 9), 10));
            this.AllIngredients.Add(new Ingredient("Parmigiano-Reggiano", "oz", 110, 8, 0, 9));

            aglioIngredinets.Add((new Ingredient("Salt and Papper", "dash", 0, 0, 0, 0), 1));
            this.AllIngredients.Add(new Ingredient("Salt and Papper", "dash", 0, 0, 0, 0));

            string[] agliotags = new string[] { "recipe", "Pasta Aglio E Olio", "Italian", "Medium", "Spaghetti", "Garlic", "Olive Oil" };

            string aglioInstructions = "1. Bring a large pot of lightly salted water to boil. Cook the spaghettin in boiling water, stirring ocasionally until cooked through but still firm to bite (roughly 12 minutes). Drain and transfer into a pasta bowl.\n" +
              "2. Combine garlic and olive oil in a cold skillet. Cook over medium heat to slowly toast the garlic (about 10 minutes). Reduce the heat to medium when olive oil begins to bubble. Cook and stir until garlic is golden brown (about 5 minutes).\n" +
              "3. Stir red pepper flakes, black pepper, and salt into the pasta. Pour in olive oil and garlic, and sprinkla on parsley and half of the Parmigiano-Reggiano cheeses; stir until combined.\n" +
              "Serve pasta topped witht eh remaining Parmigiano-Regiano.";

            //Ratatouille
            List<(Ingredient, double)> ratatouilleIngredients = new List<(Ingredient, double)>();
            //public Ingredient(string nam, string measurement, int cal, int fat, int carb, int prot)
            ratatouilleIngredients.Add((new Ingredient("Eggplants", "unpeeled", 132, 1.04, 31.24, 5.51), 2));
            ratatouilleIngredients.Add((new Ingredient("Roma Tomatoes", "", 35, 1, 2, 1), 6));
            ratatouilleIngredients.Add((new Ingredient("Yellow Squash", "", 18, 0.2, 3.79, 1.37), 2));
            ratatouilleIngredients.Add((new Ingredient("Zucchini", "", 15, 0, 3, 1), 2));
            ratatouilleIngredients.Add((new Ingredient("Olive Oil", "tbsp(s)", 119, 13.5, 0, 0), 2));
            ratatouilleIngredients.Add((new Ingredient("Diced Onion", "", 46, 0.09, 11.12, 1.01), 1));
            ratatouilleIngredients.Add((new Ingredient("Minced Garlic", "clove(s)", 4, 0.02, 0.99, 0.19), 4));
            ratatouilleIngredients.Add((new Ingredient("Diced Red Bell Pepper", "", 30, 0, 8, 1), 1));
            ratatouilleIngredients.Add((new Ingredient("Diced Yellow Bell Pepper", "", 30, 0, 8, 1), 1));
            ratatouilleIngredients.Add((new Ingredient("Crushed Tomatoes", "oz", 10, 0, 4, 1), 28));
            ratatouilleIngredients.Add((new Ingredient("Chopped Basil (8-10 leaves)", "tbsp(s)", 1, 0.03, 0.23, 0.13), 2));
            ratatouilleIngredients.Add((new Ingredient("Chopped Parsley", "tbp(s)", 1, 0.03, 0.24, 0.11), 2));
            ratatouilleIngredients.Add((new Ingredient("Thyme", "tsp(s)", 1, 0.01, 0.2, 0.04), 2));

            string[] ratatouilletags = new string[] { "recipe", "Ratatouille", "French", "Hard", "Eggplants", "Roma Tomatoes", "Yellow Squash", "Zucchini", "Basil", "Thyme", "Parsley", "Vegetarian", "Vegan" };

            string ratatouilleInstructions = "1. Preheat the oven for 375˚F (190˚C).\n\n" + "2. Slice the eggplant, tomatoes, squash, and zucchini into approximately ¹⁄₁₆-inch (1-mm) rounds, then set aside.\n\n" + "3. Make the sauce: Heat the olive oil in a 12-inch (30-cm) oven-safe pan over medium-high heat. Sauté the onion, garlic, and bell peppers until soft, about 10 minutes. Season with salt and pepper, then add the crushed tomatoes. Stir until the ingredients are fully incorporated. Remove from heat, then add the basil. Stir once more, then smooth the surface of the sauce with a spatula.\n\n" +
            "4. Arrange the sliced veggies in alternating patterns, (for example, eggplant, tomato, squash, zucchini) on top of the sauce from the outer edge to the middle of the pan. Season with salt and pepper.\n\n" + "5. Make the herb seasoning: In a small bowl, mix together the basil, garlic, parsley, thyme, salt, pepper, and olive oil. Spoon the herb seasoning over the vegetables.\n\n"
            + "6. Cover the pan with foil and bake for 40 minutes. Uncover, then bake for another 20 minutes, until the vegetables are softened.\n\n" + "7. Serve while hot as a main dish or side. The ratatouille is also excellent the next day--cover with foil and reheat in a 350˚F (180˚C) oven for 15 minutes, or simply microwave to desired temperature.\n\n";

            //Quesadillas
            List<(Ingredient, double)> quesadillaIngredients = new List<(Ingredient, double)>();
            quesadillaIngredients.Add((new Ingredient("Large Flour Tortilla", "", 218, 5.42, 35.94, 5.8), 1));
            quesadillaIngredients.Add((new Ingredient("Refried Beans", "cup", 120, 2.5, 18, 6), 0.25));
            quesadillaIngredients.Add((new Ingredient("Jalapeno", "Slices", 5, 0, 1, 0), 5));
            quesadillaIngredients.Add((new Ingredient("Shredded Cheese Blend", "cup", 110, 9, 1, 6), 0.25));
            quesadillaIngredients.Add((new Ingredient("Salsa", "To Serve", 8, 0.05, 1.77, 0.44), 1));

            string[] quesadillatags = new string[] { "recipe", "Quesadilla", "Mexican", "Medium", "Tortilla", "Refried Beans", "Jalapeno", "Cheese", "Salsa", "Vegetarian" };

            string quessadillaInstructions = "1. Using a butter knife, spread the refried beans in an even layer onto the tortilla.\n" + "2. Add the jalapeño slices and shredded cheese to the top half of the tortilla.\n" + "3. Fold the tortilla in half from the bottom, then fold in the sides, being careful not to tear the tortilla.\n"
            + "5. Toast on medium - high, until golden brown.Watch to make sure it doesn’t burn. Let cool for 1 - 2 minutes before removing from the toaster.\n" + "6. Serve with salsa, if desired.";

            //Spinach Frittata
            List<(Ingredient, double)> frittataIngredients = new List<(Ingredient, double)>();
            frittataIngredients.Add((new Ingredient("Diced Medium Onion", "", 46, 0.09, 11.12, 1.01), 0.5));
            frittataIngredients.Add((new Ingredient("Diced Large Bell Pepper", "", 30, 0, 8, 1), 0.5));
            frittataIngredients.Add((new Ingredient("Garlic", "clove(s)", 4, 0.02, 0.9, 0.19), 1));
            frittataIngredients.Add((new Ingredient("Crumbled Bacon", "", 151, 11.7, 0.4, 10.37), 0.33));
            frittataIngredients.Add((new Ingredient("Coconut Oil", "tbsp(s)", 117, 13.6, 0, 0), 3));
            frittataIngredients.Add((new Ingredient("Cream Cheese", "oz", 99, 9.89, 0.75, 2.14), 4));
            frittataIngredients.Add((new Ingredient("Parmesan Cheese", "cup", 431, 28.61, 4.06, 38.46), 1));
            frittataIngredients.Add((new Ingredient("Eggs", "", 65, 4.37, 0.34, 5.54), 8));
            frittataIngredients.Add((new Ingredient("Salt", "tsp(s)", 0, 0, 0, 0), 0.25));
            frittataIngredients.Add((new Ingredient("Black Pepper", "tsp(s)", 0, 0, 0.06, 0.01), 1));
            frittataIngredients.Add((new Ingredient("Chopped, Drained Spinach", "oz", 7, 0.11, 1.03, 0.81), 8));

            string[] frittatags = new string[] { "recipe", "Frittata", "Italian", "Medium", "Garlic", "Bacon", "Coconut Oil", "Cream Cheese", "Cheese" };

            string frittataInstructions = "1. Preheat oven to broil\n"
            + "2. Using a 10\", oven-safe skillet, saute the onions, bell peppers, and garlic in 2 tbsp of oil. Once the veggies are nearly done (about 4 minutes), add bacon crumbles and cream cheese to the mix and cook until a creamy mixture. Scoop the veggie/bacon mix into a bowl to cool while leaving the oil behind. Ensure that excess oil is drained.\n"
            + "3. In the same skillet, add the hopped spinach.Cook it down until it starts to wilt, then place it on a paper - towel - lined plate to cool, ensuring the excess oil drips off.\n"
            + "4. In the onion bowl, add the parmesan cheese and mix until even clumps form.Then add the 8 eggs, salt, and pepper, and whisk until combined.\n"
            + "5. In the same skillet, heat the remaining oil before pouring the egg / veggie mixture into it.Let it cook for 30 seconds, stirring gently with whatever utensil you used before, then evenly cover the top with spinach.Let cook for 5 minutes, or until the edges of the mixture start turning a light brown.\n"
            + "6. Place the skillet in the oven with the broil on.Cook for 5 - 8 minutes, until the surface is golden brown.\n"
            + "7. Take out the skillet, cool, and serve while warm.";


            //Teriyaki Chicken
            List<(Ingredient, double)> teriyakiIngredients = new List<(Ingredient, double)>();
            teriyakiIngredients.Add((new Ingredient("Chicken Thigh", "lb", 1102, 69.12, 0, 111.825), 2));
            this.AllIngredients.Add(new Ingredient("Chicken Thigh", "lb", 1102, 69.12, 0, 111.825));
            teriyakiIngredients.Add((new Ingredient("Soy Sauce", "cup(s)", 135, 0.1, 19.41, 16.01), 1));
            this.AllIngredients.Add(new Ingredient("Soy Sauce", "cup(s)", 135, 0.1, 19.41, 16.01));
            teriyakiIngredients.Add((new Ingredient("Brown Sugar", "cup(s)", 547, 0, 141.13, 0), 0.5));
            this.AllIngredients.Add(new Ingredient("Brown Sugar", "cup(s)", 547, 0, 141.13, 0));

            string[] teriyakitags = new string[] { "recipe", "Teriyaki Chicken", "Japanese", "Easy", "Chicken", "Soy sauce", "Brown Sugar" };

            string teriyakiInstructions = "1. Sear the chicken thighs evenly in a pan, then flip. \n" + "2. Add the soy sauce and brown sugar, stirring and bringing to a boil.\n"
            + "3. Stir until the sauce has reduced and evenly glazes the chicken.\n";

            //Whipped Coffee
            List<(Ingredient, double)> coffeeIngredients = new List<(Ingredient, double)>();
            coffeeIngredients.Add((new Ingredient("Hot Water", "tbsp(s)", 0, 0, 0, 0), 2));
            this.AllIngredients.Add(new Ingredient("Hot Water", "tbsp(s)", 0, 0, 0, 0));
            coffeeIngredients.Add((new Ingredient("Sugar", "tbsp(s)", 16, 0, 4.2, 0), 2));
            this.AllIngredients.Add(new Ingredient("Sugar", "tbsp(s)", 16, 0, 4.2, 0));
            coffeeIngredients.Add((new Ingredient("Instant Coffee Powder", "tbsp(s)", 2, 0, 0.37, 0.11), 2));
            this.AllIngredients.Add(new Ingredient("Instant Coffee Powder", "tbsp(s)", 2, 0, 0.37, 0.11));
            coffeeIngredients.Add((new Ingredient("Milk", "cup", 12, 4.88, 11.49, 8.03), 0.05));
            this.AllIngredients.Add(new Ingredient("Milk", "cup", 12, 4.88, 11.49, 8.03));

            string[] coffeetags = new string[] { "recipe", "Whipped Coffee", "Italian", "Easy", "Coffee", "Milk", "Sugar", "Vegetarian"};

            string coffeeInstructions = "1. Add the hot water, sugar, and instant coffee to a bowl.\n" +
            "2. Either hand whisk or use an electric mixer until the mixture is fluffy and light.\n" +
            "3. To serve, spoon a dollop over a cup of milk with ice in it and stir.";

            //Strawberry Sorbet
            List<(Ingredient, double)> strawberrySorbetIngredients = new List<(Ingredient, double)>();
            strawberrySorbetIngredients.Add((new Ingredient("Strawberry", "lb", 144, 1.35, 7.68, 3.015), 1));
            strawberrySorbetIngredients.Add((new Ingredient("Honey", "cup(s)", 64, 0, 17.3, 0.06), 0.25));

            string[] strawberrySorbetags = new string[] { "recipe", "Strawberry Sorbet", "French", "Easy", "Strawberry", "Honey", "Vegetarian"};

            string strawberrySorbetInstructions = "1. Hull the strawberries by using a straw to push out the stem of each strawberry.\n" +
            "2. Cut strawberries in half and place on a parchment paper - lined baking sheet and freeze until hardened.\n" +
            "3. Add the frozen strawberries and honey to a food processor and combine until evenly mixed.\n" +
            "4. Transfer to a loaf pan and transfer to freezer until completely frozen.";

            //Cheesy Egg Toast
            List<(Ingredient, double)> eggToastIngredients = new List<(Ingredient, double)>();
            eggToastIngredients.Add((new Ingredient("Slice Bread", "", 80, 1, 16, 3), 1));
            eggToastIngredients.Add((new Ingredient("Butter", "tbsp(s)", 102, 11.52, 0.01, 0.12), 0.5));
            eggToastIngredients.Add((new Ingredient("Shredded Cheese", "tbsp(s)", 20, 1, 0, 2), 3));
            eggToastIngredients.Add((new Ingredient("Egg", "", 65, 4.37, 0.34, 5.54), 1));
            eggToastIngredients.Add((new Ingredient("Salt", "to taste", 0, 0, 0, 0), 1));
            eggToastIngredients.Add((new Ingredient("Pepper", "to taste", 0, 0, 0, 0), 1));

            string[] eggToastags = new string[] { "recipe", "Cheesy Egg Toast", "French", "Medium", "Bread", "Egg", "Butter", "Cheese" };

            string eggToastInstructions = "1. With a spoon, press down on the center of the bread to form a pocket.\n 2. Line the edges of the bread with butter, and crack an egg into the pocket.\n 3.Line the edges of the bread with shredded cheese. \n" +
            "4.Sprinkle on salt and pepper, and bake at 400°F(204°C) for 10 - 15 min. 10 min will have a runny yolk whereas 15 min will have a firmer yolk.";

            //Spaghetti With Garlic And Oil Pasta
            List<(Ingredient, double)> spaghettiIngredients = new List<(Ingredient, double)>();
            spaghettiIngredients.Add((new Ingredient("Spaghetti", "lb", 220, 1.29, 42.95, 8.06), 0.5));
            spaghettiIngredients.Add((new Ingredient("Extra Virgin Olive Oil", "tbsp(s)", 119, 13.5, 0, 0), 3));
            spaghettiIngredients.Add((new Ingredient("Salt", "to taste", 0, 0, 0, 0), 1));
            spaghettiIngredients.Add((new Ingredient("Sliced Garlic", "clove(s)", 4, 0.02, 0.99, 0.19), 4));
            spaghettiIngredients.Add((new Ingredient("Red Chili Flakes", "tsp(s)", 5, 0.3, 1, 0.2), 1));
            spaghettiIngredients.Add((new Ingredient("Parsley (Optional: Finely Chopped)", "tbsp(s)", 22, 0.47, 3.8, 1.78), 2));

            string[] spaghettitags = new string[] { "recipe", "Spaghetti With Garlic And Oil Pasta", "Italian", "Medium", "Garlic", "Spaghetti", "Olive Oil", "Parsley", "Vegetarian", "Vegan"};

            string spaghettiInstructions = "Bring a large pot of salted water to a boil. Cook the pasta according to package instructions. Save ¼ cup (60 ml) of pasta water, then drain.\n 2.Add the olive oil and garlic to a large cold sauté pan. Turn the heat to medium - low and slowly heat up until the garlic is fragrant and lightly colored, about 3 minutes. \n 3.Add the chile flakes and cook for another minute. \n 4. Add the reserved pasta water and bring to a simmer.Add the cooked spaghetti and parsley, if using. Stir until the pasta is well - coated.Season with salt to taste.";

            //Grilled Cheese
            List<(Ingredient, double)> grilledCheeseIngredients = new List<(Ingredient, double)>();
            grilledCheeseIngredients.Add((new Ingredient("Sourdough Bread", "piece(s)", 68, 0.75, 12.98, 2.2), 2));
            grilledCheeseIngredients.Add((new Ingredient("Unsalted Butter", "tbsp(s)", 100, 11, 0, 0), 1.5));
            grilledCheeseIngredients.Add((new Ingredient("Maoynnaise", "tbsp(s)", 57, 4.91, 3.51, 0.31), 1.5));
            grilledCheeseIngredients.Add((new Ingredient("Cheddar Cheese", "slice(s)", 113, 9.28, 0.36, 6.97), 3));

            string[] grilledCheesetags = new string[] { "recipe", "Grilled Cheese", "English", "Medium", "Bread", "Butter", "Mayonnaise", "Cheese" };

            string grilledCheeseInstructions = "1. On a cutting board, butter each piece of bread with butter on one side.\n" +
            "2. Flip the bread over and spread each piece of bread with mayonnaise.\n" +
            "3. Place the cheese on the buttered side of one piece of bread. Top it with the second piece of bread, mayonnaise side out.\n" +
            "4. Heat a nonstick pan over medium low heat.\n" +
            "5. Place the sandwich on the pan, mayonnaise side down.\n" +
            "6. Cook for 3 - 4 minutes, until golden brown.\n" +
            "7. Using a spatula, flip the sandwich over and continue cooking until golden brown, about 2 - 3 minutes.";

            //Cookies and Cream Fudge
            List<(Ingredient, double)> cookiesAndCreamIngredients = new List<(Ingredient, double)>();
            cookiesAndCreamIngredients.Add((new Ingredient("White Chocolate", "oz", 153, 9.1, 16.79, 1.66), 18));
            cookiesAndCreamIngredients.Add((new Ingredient("Sweetened Condense Milk", "oz", 123, 3.32, 20.78, 3.02), 14));
            cookiesAndCreamIngredients.Add((new Ingredient("Sandwich Cookies", "chopped", 47, 1.95, 7.19, 0.49), 12));

            string[] cookiesAndCreamtags = new string[] { "recipe", "Cookies and Cream Fudge", "French", "White Chocolate", "Condense Milk", "Cookies" };

            string cookiesAndCreamInstructions = "In a mixing bowl, combine chocolate with sweetened condensed milk and melt in the microwave in 15-second increments.\n" +
            "2. Once chocolate is fully melted, add in chopped cookies and stir until combined.\n" +
            "3. Pour chocolate mixture into a parchment paper - lined 8x8 inch(20x20 cm) baking tin. \n" +
            "4. Chill for 2 hours or until the fudge is firm.\n" +
            "5. Cut into bite - sized pieces.";

            //Banana Oat Smoothie
            List<(Ingredient, double)> bananaSmoothieIngredients = new List<(Ingredient, double)>();
            bananaSmoothieIngredients.Add((new Ingredient("Rolled Oats", "cup(s)", 95, 8, 66, 12), 0.5));
            bananaSmoothieIngredients.Add((new Ingredient("Banana", "", 105, 0.39, 26.95, 1.29), 1));
            bananaSmoothieIngredients.Add((new Ingredient("Milk", "cup(s)", 146, 7.93, 11.03, 7.86), 1));

            string[] bananaSmoothietags = new string[] { "recipe", "Banana Oat Smoothie", "Italian", "Medium", "Oat", "Banana", "Milk", "Vegetarian"};

            string bananaSmoothieInstructions = "1.Add rolled oats to a blender and blend until the oats are the size of a fine crumb.\n" + "2. Add the banana and milk and blend well.\n" + "3. Pour in a glass.";

            //Pumpkin Bread
            List<(Ingredient, double)> pumpkinBreadIngredients = new List<(Ingredient, double)>();
            pumpkinBreadIngredients.Add((new Ingredient("Spice Cake Mix", "box", 160, 1.5, 35, 2), 1));
            pumpkinBreadIngredients.Add((new Ingredient("Pureed Pumpkin", "can", 140, 0, 35, 3.5), 14));
            pumpkinBreadIngredients.Add((new Ingredient("Frosting", "oz", 115, 2.99, 22.56, 0.07), 8));

            string[] pumpkinBreadtags = new string[] { "recipe", "Pumpkin Bread", "American", "Hard", "Cake", "Pumpkin", "Frosting" };

            string pumpkinBreadInstructions = "1.Mix the spice cake mix and pureed pumpkin.\n" + "2. Spread into a greased loaf pan. Bake at 350°F(175°C) for 55 - 60 min.Cool completely.\n" + "3. Frost to your liking!";

            //Creamy Bacon Hasselback Chicken
            List<(Ingredient, double)> creamyBaconChickenIngredients = new List<(Ingredient, double)>();
            creamyBaconChickenIngredients.Add((new Ingredient("Chicken Breast", "", 27, 1.08, 0, 4.14), 4));
            creamyBaconChickenIngredients.Add((new Ingredient("Chopped Rashers Bacon", "", 37, 2.9, 0.55, 2.2), 4));
            creamyBaconChickenIngredients.Add((new Ingredient("Chopped Spring Onions", "", 5, 0.03, 1.1, 0.27), 2));
            creamyBaconChickenIngredients.Add((new Ingredient("Cream Cheese", "cup", 810, 80.9, 6.17, 17.52), 0.5));

            string[] creamyBaconChickentags = new string[] { "recipe", "Creamy Bacon Hasselback Chicken", "French", "Medium", "Chicken", "Bacon", "Cream Cheese" };

            string creamyBaconChickenInstructions = "1. Slice into the chicken several times, about ½ cm (¼ inch) apart, but only cut about 85% of the way through, leaving the bottom intact.\n" +
            "2. Cook the bacon over a medium heat until it starts to get crispy.\n" +
            "3. Preheat the oven to 350°F(180°C).\n" +
            "4. Stir in the spring onions and cook for another minute or so.\n" +
            "5. Add the cream cheese and cook until melted.\n" +
            "6. Allow filling to cool to the touch, and then fill each segment of the chicken breast with about 1 teaspoon of the mixture." +
            "7. Bake in the centre of the oven for 18 - 22 minutes until the chicken is cooked through and the juices run clear.";

            //Creme Brulee
            List<(Ingredient, double)> cremeBruleeIngredients = new List<(Ingredient, double)>();
            cremeBruleeIngredients.Add((new Ingredient("Vanilla Ice Cream", "cup(s)", 290, 15.84, 33.98, 5.04), 0.5));
            cremeBruleeIngredients.Add((new Ingredient("egg yolk", "", 55, 4.51, 0.61, 2.7), 1));
            cremeBruleeIngredients.Add((new Ingredient("Sugar", "tbsp(s)", 16, 0, 4.2, 0), 1));

            string[] cremeBruleetags = new string[] { "recipe", "Creme Brulee", "French", "Medium", "Vanilla", "Ice Cream", "Egg" };


            string cremeBruleeInstructions = "1. Preheat the oven to 325˚F (160˚C).\n" +
            "2. Scoop the ice cream in a microwave-safe bowl.Microwave the ice cream for 30 to 40 seconds or until completely melted.Allow to cool for 5 minutes.\n" +
            "3. Add the egg yolk into the melted ice cream and whisk well.\n" +
            "4. Pour the mixture into a ramekin.Place the ramekin in a pan.Pour hot water into the pan to come roughly halfway up the sides of the ramekin.\n" +
            "5. Bake for 40 - 50 minutes.The crème brûlée should be set, but still a little jiggly in the middle.Remove the ramekins from the roasting pan, allow to cool to room temperature, cover with plastic wrap and refrigerate for at least 2 hours, and up to 3 days.\n" +
            "6. Remove the crème brûlée from the refrigerator for at least 30 minutes before browning the sugar on top.\n" +
            "7.Sprinkle a tablespoon of sugar on top of each crème brûlée.Using a torch, melt the sugar to for a crispy top.If you don’t have a torch, you can broil the crème brûlée to melt the sugar.Keep an eye on it, to make sure you don’t over cook it.Allow the crème brûlée to sit for at least 5 minutes before serving. \n" +
            "8. You can also make various flavor by using different ice cream flavors. If you are using flavored ice cream, use 1 egg instead of 1 yolk.";

            //public Recipe(string name, int rate, int diff, string img, int time, List<(Ingredient, double)> ingredients, string[] tags, string instructions)
            
            //All recipes
            this.AllRecipes.Add(new Recipe("Creme Brulee", 4, 2, "cremebrulee.png", 70, cremeBruleeIngredients, cremeBruleetags, cremeBruleeInstructions));
            this.AllRecipes.Add(new Recipe("Creamy Bacon Hasselback Chicken", 4, 3, "creamybacon.png", 60, creamyBaconChickenIngredients, creamyBaconChickentags, creamyBaconChickenInstructions));
            this.AllRecipes.Add(new Recipe("Pumpkin Bread", 4, 2, "pumpkinbread.png", 70, pumpkinBreadIngredients, pumpkinBreadtags, pumpkinBreadInstructions));
            
            this.AllRecipes.Add(new Recipe("Banana Oat Smoothie", 2, 1, "bananasmoothie.png", 15, bananaSmoothieIngredients, bananaSmoothietags, bananaSmoothieInstructions));
            Recipe cookiesCreamRcp = new Recipe("Cookies and Cream", 4, 1, "cookiesandcream.png", 135, cookiesAndCreamIngredients, cookiesAndCreamtags, cookiesAndCreamInstructions);
            this.AllRecipes.Add(cookiesCreamRcp);
            this.AllRecipes.Add(new Recipe("Grilled Cheese", 4, 1, "grilledcheese.png", 10, grilledCheeseIngredients, grilledCheesetags, grilledCheeseInstructions));
            this.AllRecipes.Add(new Recipe("Spaghetti with Garlic and Oil Pasta", 3, 2, "spaghetti2.jpg", 30, spaghettiIngredients, spaghettitags, spaghettiInstructions));
            this.AllRecipes.Add(new Recipe("Cheesy Egg Toast", 4, 1, "eggtoast.png", 30, eggToastIngredients, eggToastags, eggToastInstructions));
            Recipe ratRcp = new Recipe("Ratatouille", 5, 2, "ratatouille.png", 70, ratatouilleIngredients, ratatouilletags, ratatouilleInstructions);
            this.AllRecipes.Add(ratRcp);
            this.AllRecipes.Add(new Recipe("Strawberry Sorbet", 4, 1, "strawberrySorbet2.jpg", 15, strawberrySorbetIngredients, strawberrySorbetags, strawberrySorbetInstructions));
            this.AllRecipes.Add(new Recipe("Whipped Coffee", 3, 0, "coffee.png", 15, coffeeIngredients, coffeetags, coffeeInstructions));
            Recipe aglioRcp = new Recipe("Pasta Aglio E Olio", 4, 1, "aglioEOlio.png", 30, aglioIngredinets, agliotags, aglioInstructions);
            this.AllRecipes.Add(aglioRcp);
            this.AllRecipes.Add(new Recipe("Spinach Frittata", 5, 1, "frittata.png", 25, frittataIngredients, frittatags, frittataInstructions));
            Recipe teriyakiRcp = new Recipe("Teriyaki Chicken", 3, 0, "teriyaki2.jpg", 27, teriyakiIngredients, teriyakitags, teriyakiInstructions);
            this.AllRecipes.Add(teriyakiRcp);
            this.AllRecipes.Add(new Recipe("Bean And Cheese Toaster Quesadilla", 4, 1, "quesadilla.png", 25, quesadillaIngredients, quesadillatags, quessadillaInstructions));

            //Featured Recipes
            //this.FeaturedRecipes.Add(ratRcp);    
            this.FeaturedRecipes.Add(teriyakiRcp);
            this.FeaturedRecipes.Add(aglioRcp);
            this.FeaturedRecipes.Add(cookiesCreamRcp);



            //Optional My recipes.
        }
    }
}
