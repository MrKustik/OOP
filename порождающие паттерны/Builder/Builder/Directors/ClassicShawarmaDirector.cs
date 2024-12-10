using Builder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class ClassicShawarmaDirector
    {
        private ClassicShawarmaBuilder _builder;

        public ClassicShawarmaDirector(ClassicShawarmaBuilder builder)
        {
            _builder = builder;
        }

        public void MakeClassicShawarma()
        {
            _builder.AddMeat();
            _builder.AddVegetables();
            _builder.AddSauce();
            _builder.AddCheese();
        }
    }
}
