using Fabric.Cars;
using Fabric.Motorcycles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Creators
{
    public class ToyotaCreator : VehicleCreator
    {
        public override Car CreateCar()
        {
            return new ToyotaCar();
        }
        public override Motorcycle CreateMotorcycle()
        {
            return new ToyotaMotorcycle();
        }
    }
}
