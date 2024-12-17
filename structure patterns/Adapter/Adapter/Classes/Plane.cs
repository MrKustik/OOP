using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    internal class Plane : IPlane
    {
        public void Fly()
        {
            Console.WriteLine("самолет летит");
        }
    }
}
