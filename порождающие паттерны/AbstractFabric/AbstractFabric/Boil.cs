﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    class Boil : Cooking
    {
        public override void Cook()
        {
            Console.WriteLine("Варим");
        }
    }
}
