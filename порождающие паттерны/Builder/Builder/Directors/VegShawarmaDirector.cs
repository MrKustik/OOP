using Builder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class VegShawarmaDirector
    {
        private VegShawarmaBuilder _builder;

        public VegShawarmaDirector(VegShawarmaBuilder builder)
        {
            _builder = builder;
        }

        public void MakeVegShawarma()
        {
            _builder.AddMeat();
            _builder.AddVegetables();
            _builder.AddSauce();
            _builder.AddCheese();
        }
    }
}
