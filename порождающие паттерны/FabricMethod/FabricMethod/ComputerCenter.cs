using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    abstract class ComputerCenter
    {
        public string Name {  get; set; }
        public ComputerCenter(string name)
        {
            this.Name = name;
        }
        abstract public Computer Create();
    }
}
