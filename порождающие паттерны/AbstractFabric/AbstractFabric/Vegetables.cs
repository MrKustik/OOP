using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class Vegetables : Ingredients
    {
        public override void Ingredient()
        {
            Console.WriteLine("Овощи");
        }
    }
}
