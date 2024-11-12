using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    class HyperPc : ComputerCenter
    {
        public HyperPc(string n) : base(n) { }
        public override Computer Create()
        {
            return new GameComputer();
        }
    }
}
