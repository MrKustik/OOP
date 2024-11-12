using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class Fry : Cooking
    {
        public override void Cook()
        {
            Console.WriteLine("Жарим");
        }
    }
}
