using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    abstract class DumplingsFacory
    {
        public abstract Cooking CreateCooking();
        public abstract Ingredients CreateIngredients();
    }
}
