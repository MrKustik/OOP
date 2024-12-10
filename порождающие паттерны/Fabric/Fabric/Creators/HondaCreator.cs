using Fabric.Cars;
using Fabric.Motorcycles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Creators
{
    public class HondaCreator : VehicleCreator
    {
        public override Car CreateCar()
        {
            return new HondaCar();
        }
        public override Motorcycle CreateMotorcycle()
        {
            return new HondaMotorcycle();
        }
    }
}
