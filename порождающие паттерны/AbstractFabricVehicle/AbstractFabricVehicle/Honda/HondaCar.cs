using AbstractFabricVehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricVehicle.Honda
{
    public class HondaCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Honda car.");
        }
    }
}
