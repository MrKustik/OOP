using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class UniversalShawarmaDirector
    {
        private IShawarmaBuilder _builder;

        public UniversalShawarmaDirector(IShawarmaBuilder builder)
        {
            _builder = builder;
        }

        public void MakeShawarma()
        {
            _builder.AddMeat();
            _builder.AddVegetables();
            _builder.AddSauce();
            _builder.AddCheese();
        }
    }
}
