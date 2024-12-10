namespace Singletone
{
    public class ShawarmaSingletone
    {
        private string Meat { get; }
        private string Souce { get; }
        private string Cheese { get; }
        private string Lavash { get; }

        private ShawarmaSingletone(string meat, string souce, string cheese, string lavash)
        {
            Meat = meat;
            Souce = souce;
            Cheese = cheese;
            Lavash = lavash;
        }

        private static ShawarmaSingletone _instance;

        public static ShawarmaSingletone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = readConfig();
                }
                return _instance;
            }
        }

        private static ShawarmaSingletone readConfig()
        {
            return new ShawarmaSingletone("beef", "yogurt", "parmezan", "lavash");
        }
    }
}