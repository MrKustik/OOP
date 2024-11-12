using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class Meat : Ingredients
    {
        public override void Ingredient()
        {
            Console.WriteLine("Мясо");
        }
    }
}
