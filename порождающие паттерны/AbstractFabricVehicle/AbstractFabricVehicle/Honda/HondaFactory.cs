using AbstractFabricVehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricVehicle.Honda
{
    public class HondaFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new HondaCar();
        }

        public IMotorcycle CreateMotorcycle()
        {
            return new HondaMotorcycle();
        }
    }
}
