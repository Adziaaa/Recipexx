using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace coos
{
    public class Rec1 : IRecipe
    {
        public List<Recipeinformation> recipes = new List<Recipeinformation>();

        public void Add(Guid recipeId, string title, string instructions, string category, List<string> ingredients)
        {
            var inputuser = new Recipeinformation(recipeId, title, instructions, category, ingredients);
            recipes.Add(inputuser);
        }
        public void Delete(Guid recipeId, string title, string instructions, string category, List<string> ingredients)
        {
            var userinput = new Recipeinformation(recipeId, title, instructions, category, ingredients);
            recipes.Remove(userinput);
        }
        public void Update(Guid recipeId, string title, string instructions, string category, List<string> ingredients)
        {
            var old = new Recipeinformation(recipeId, title, instructions, category, ingredients);
            recipes.Remove(old);
            Console.WriteLine("Update your recipe.");
            // add new uppdated recipe
            var new_one = new Recipeinformation(recipeId, title, instructions, category, ingredients);
            recipes.Add(new_one);
        }

        public void View()
        {
            foreach (var rec_singleone in recipes)
            {
                Console.WriteLine(rec_singleone.Title);
                Console.WriteLine("\n ");
                Console.WriteLine(rec_singleone.Category, rec_singleone.Ingredients);
            }
        }
        public void Search(string choice, string userinfo, string category, List<string> ingredients)
        {
            Console.WriteLine("Choose \n " +
                "1. Search by ingredi3ent \n" +
                "2. Search by category");
            userinfo = Console.ReadLine();

            if (recipes.Contains(userinfo))
            {
                Console.WriteLine("Type the ingredient");
                string ingr = Console.ReadLine();
                // o co cho
                /* if (ingredients.Contains(ingr))
                 {
                     //show only those recipes withh  that ingredient
                 }
                 else;
                 {
                     Console.WriteLine($"there isnt any ingredient like {ingr}");

                 }
                */
            }
            else if (userinfo == "2")
            {
                Console.WriteLine("Type the category");
                choice = Console.ReadLine();
                if (!string.IsNullOrEmpty(choice) || choice == category)
                {
                    //foreach element in viewmethod that has that category
                    return recipes.Contains(choice);

                }
                else
                { Console.WriteLine("Invalid choice."); }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void Categorise(Guid recipeId, string category)
        {

            var recipeinformation = recipes.FirstOrDefault(r => r.RecipeId == Guid.Parse(recipeId.ToString()));
            if (recipeinformation != null)
            {
                recipeinformation.Category = category;
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }


    }
}
