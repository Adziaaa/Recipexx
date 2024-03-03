using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coos
{
    public class Recipeinformation
    {
        public Guid RecipeId { get; internal set; } = Guid.NewGuid();

        public string Title { get; set; }

        public List<string> Ingredients
        {
            get { return Ingredients; }
            set { Ingredients = value; }
        }
        public string Instructions { get; set; }
        public string Category { get; set; }

        public Recipeinformation(Guid recipeId, string title, string instructions, string category, List<string> ingredients)
        {
            recipeId = RecipeId;
            title = Title;
            instructions = Instructions;
            category = Category;
            Ingredients = ingredients;
        }

    }
}
