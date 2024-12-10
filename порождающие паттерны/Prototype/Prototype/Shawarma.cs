namespace Prototype
{
    public class Shawarma : IShawarmaPrototype
    {
        public string Meat { get; set; }
        public string Vegetables { get; set; }
        public string Sauce { get; set; }

        public Shawarma(string meat, string vegetables, string sauce)
        {
            Meat = meat;
            Vegetables = vegetables;
            Sauce = sauce;
        }
        public IShawarmaPrototype Clone()
        {
            return new Shawarma(Meat, Vegetables, Sauce);
        }

        public override string ToString()
        {
            return $"Шаурма: мясо = {Meat}, овощи = {Vegetables}, соус = {Sauce}";
        }
    }
}
