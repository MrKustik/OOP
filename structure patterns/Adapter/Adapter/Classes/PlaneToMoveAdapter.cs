using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    internal class PlaneToMoveAdapter : IMove
    {
        Plane plane;
        public PlaneToMoveAdapter(Plane p)
        {
            plane = p;
        }
        public void Drive()
        {
            plane.Fly();
        }
    }
}
