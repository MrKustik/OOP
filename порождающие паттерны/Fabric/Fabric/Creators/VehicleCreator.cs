using Fabric.Cars;
using Fabric.Motorcycles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Fabric.Creators
{
    public abstract class VehicleCreator
    {
        public abstract Car CreateCar();
        public abstract Motorcycle CreateMotorcycle();
        public void CreateAndUseVehicle()
        {
            var car = CreateCar();
            var motorcycle = CreateMotorcycle();
            Console.WriteLine(car.Drive());
            Console.WriteLine(motorcycle.Ride());
        }
    }
}
