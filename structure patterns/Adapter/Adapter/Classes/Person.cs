using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes
{
    internal class Person
    {
        public void Move(IMove transport)
        {
            transport.Drive();
        }
    }
}
