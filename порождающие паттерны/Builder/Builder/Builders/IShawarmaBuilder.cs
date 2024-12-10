using Builder.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public interface IShawarmaBuilder
    {
        void AddMeat();
        void AddVegetables();
        void AddSauce();
        void AddCheese();
        Shawarma GetShawarma();
    }
}
