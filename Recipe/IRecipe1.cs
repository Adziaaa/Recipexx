using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coos
{
    public interface IRecipe
    {
        void Add(Guid recipeId, string title, string instructions, string category, List<string> Ingredients);

        void View(); // lista przepisow
        void Categorise(Guid recipeId, string category);
        void Update(Guid recipeId, string title, string instructions, string category, List<string> Ingredients);
        void Search(string choice, string userinfo, string category, List<string> ingredients);
        void Delete(Guid recipeId, string title, string instructions, string category, List<string> Ingredients);
    }
    public interface IRecipeStorage
    {
        void Save(List<Recipeinformation> Recipe);
        List<Recipeinformation> Load();
        //  void Load() => throw new NotImplementedException();
    }
}
