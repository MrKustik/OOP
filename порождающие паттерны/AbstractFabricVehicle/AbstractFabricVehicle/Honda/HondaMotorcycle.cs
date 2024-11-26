using AbstractFabricVehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricVehicle.Honda
{
    public class HondaMotorcycle : IMotorcycle
    {
        public void Ride()
        {
            Console.WriteLine("Riding a Honda motorcycle.");
        }
    }
}
