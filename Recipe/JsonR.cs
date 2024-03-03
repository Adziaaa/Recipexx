using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace coos
{

    public class JsonR : IRecipeStorage
    {
        private readonly string filePath = "recipes.json";
        public void Save(List<Recipeinformation> Recipes)
        {
            try
            {
                string json = JsonSerializer.Serialize(Recipes);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception");
            }

        }
        public List<Recipeinformation> Load()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<Recipeinformation>>(json);
                }
                return new List<Recipeinformation>();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception");
                return new List<Recipeinformation>();
            }
        }


    }
}


