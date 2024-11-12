using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class MixedBoiledDumplings : DumplingsFacory
    {
        public override Cooking CreateCooking()
        {
            return new Boil();
        }
        public override Ingredients CreateIngredients()
        {
            return new Mix();
        }
    }
}
