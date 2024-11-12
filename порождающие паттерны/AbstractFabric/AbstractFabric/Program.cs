using AbstractFabric;
using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("Пельмени на 1 столик");
        Dumplings Table1 = new Dumplings(new MeatFryedDumplings());
        Table1.Ingredients();
        Table1.Cook();
        Console.WriteLine("\nПельмени на 2 столик");
        Dumplings Table2 = new Dumplings(new MixedBoiledDumplings());
        Table2.Ingredients();
        Table2.Cook();
    }
}