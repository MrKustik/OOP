﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    class DNS : ComputerCenter
    {
        public DNS(string n) : base(n) { }
        public override Computer Create()
        {
            return new OfficeComputer();
        }
    }
}
