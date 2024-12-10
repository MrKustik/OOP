using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes
{
    public class VegShawarmaBuilder : IShawarmaBuilder
    {
        private Shawarma _shawarma = new Shawarma();

        public void AddMeat()
        {
            _shawarma.AddIngredient("Замена мяса: соевое мясо");
        }

        public void AddVegetables()
        {
            _shawarma.AddIngredient("Овощи: помидоры, огурцы, перец");
        }

        public void AddSauce()
        {
            _shawarma.AddIngredient("Соус: йогуртовый");
        }

        public void AddCheese()
        {
            _shawarma.AddIngredient("Сыр: фета");
        }

        public Shawarma GetShawarma()
        {
            return _shawarma;
        }
    }

}
