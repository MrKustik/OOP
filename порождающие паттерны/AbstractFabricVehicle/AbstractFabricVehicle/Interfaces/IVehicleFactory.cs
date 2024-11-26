using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabricVehicle.Interfaces
{
    public interface IVehicleFactory
    {
        ICar CreateCar();
        IMotorcycle CreateMotorcycle();
    }
}
