using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class Shawarma
    {
        private StringBuilder _ingredients = new StringBuilder();

        public void AddIngredient(string ingredient)
        {
            _ingredients.AppendLine(ingredient);
        }

        public string GetRecipe()
        {
            return _ingredients.ToString();
        }
    }
}
