using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class ClassicShawarmaBuilder : IShawarmaBuilder
    {
        private Shawarma _shawarma = new Shawarma();

        public void AddMeat()
        {
            _shawarma.AddIngredient("Мясо: курица");
        }

        public void AddVegetables()
        {
            _shawarma.AddIngredient("Овощи: помидоры, огурцы, капуста");
        }

        public void AddSauce()
        {
            _shawarma.AddIngredient("Соус: чесночный");
        }

        public void AddCheese()
        {
            _shawarma.AddIngredient("Сыр: моцарелла");
        }

        public Shawarma GetShawarma()
        {
            return _shawarma;
        }
    }

}
