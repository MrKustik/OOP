using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    internal class Car : IMove
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет");
        }
    }
}
