﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class VegetableBakedDumplings : DumplingsFacory
    {
        public override Cooking CreateCooking()
        {
            return new Bake();
        }
        public override Ingredients CreateIngredients()
        {
            return new Vegetables();
        }
    }
}
