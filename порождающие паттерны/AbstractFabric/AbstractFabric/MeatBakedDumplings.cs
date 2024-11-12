using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class MeatBakedDumplings : DumplingsFacory
    {
        public override Cooking CreateCooking()
        {
            return new Bake();
        }
        public override Ingredients CreateIngredients()
        {
            return new Meat();
        }
    }
}
