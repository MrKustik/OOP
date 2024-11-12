using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class Dumplings
    {
        private Ingredients ingredients;
        private Cooking cooking;
        public Dumplings(DumplingsFacory factory)
        {
            ingredients = factory.CreateIngredients();
            cooking = factory.CreateCooking();
        }
        public void Cook()
        {
            cooking.Cook();
        }
        public void Ingredients()
        {
            ingredients.Ingredient();
        }
    }
}
