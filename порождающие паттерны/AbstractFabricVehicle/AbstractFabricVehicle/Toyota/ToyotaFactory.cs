using AbstractFabricVehicle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricVehicle.Toyota
{
    public class ToyotaFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new ToyotaCar();
        }

        public IMotorcycle CreateMotorcycle()
        {
            return new ToyotaMotorcycle();
        }
    }
}
