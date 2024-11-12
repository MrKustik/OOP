using System;
using System.Collections.Generic;
using System.Text;

// Класс "Shawarma" — конечный продукт
public class Shawarma
{
    public List<string> Meat { get; set; } = new List<string>();
    public List<string> Sauce { get; set; } = new List<string>();
    public List<string> Vegetables { get; set; } = new List<string>();
    public List<string> Extras { get; set; } = new List<string>();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Шаурма:");
        sb.AppendLine($"Мясо: {string.Join(", ", Meat)}");
        sb.AppendLine($"Соус: {string.Join(", ", Sauce)}");
        sb.AppendLine($"Овощи: {string.Join(", ", Vegetables)}");
        sb.AppendLine($"Дополнения: {string.Join(", ", Extras)}");
        return sb.ToString();
    }
}

// Интерфейс билдера для шаурмы
public interface IShawarmaBuilder
{
    void AddMeat(string meat);
    void AddSauce(string sauce);
    void AddVegetables(string vegetables);
    void AddExtras(string extras);
    Shawarma GetShawarma();
}

// Реализация билдера для кастомной шаурмы
public class CustomShawarmaBuilder : IShawarmaBuilder
{
    private Shawarma _shawarma = new Shawarma();

    public void AddMeat(string meat)
    {
        _shawarma.Meat.Add(meat);
    }

    public void AddSauce(string sauce)
    {
        _shawarma.Sauce.Add(sauce);
    }

    public void AddVegetables(string vegetables)
    {
        _shawarma.Vegetables.Add(vegetables);
    }

    public void AddExtras(string extras)
    {
        _shawarma.Extras.Add(extras);
    }

    public Shawarma GetShawarma()
    {
        return _shawarma;
    }
}

// Директор для управления сборкой шаурмы
public class ShawarmaDirector
{
    private IShawarmaBuilder _builder;

    public ShawarmaDirector(IShawarmaBuilder builder)
    {
        _builder = builder;
    }

    public void MakeCustomShawarma()
    {
        Console.WriteLine("Выберите мясо:");
        Console.WriteLine("1. Курица\n2. Говядина\n3. Свинина\n4. Соевое мясо");
        ChooseMultipleOptions(new[] { "Курица", "Говядина", "Свинина", "Соевое мясо" }, _builder.AddMeat);

        Console.WriteLine("Выберите соус:");
        Console.WriteLine("1. Чесночный\n2. Томатный\n3. Острый\n4. Йогуртовый");
        ChooseMultipleOptions(new[] { "Чесночный", "Томатный", "Острый", "Йогуртовый" }, _builder.AddSauce);

        Console.WriteLine("Выберите овощи:");
        Console.WriteLine("1. Огурцы и помидоры\n2. Капуста\n3. Листья салата\n4. Без овощей");
        ChooseMultipleOptions(new[] { "Огурцы и помидоры", "Капуста", "Листья салата", "Без овощей" }, _builder.AddVegetables);

        Console.WriteLine("Выберите дополнения:");
        Console.WriteLine("1. Сыр\n2. Картофель фри\n3. Грибы\n4. Без дополнений");
        ChooseMultipleOptions(new[] { "Сыр", "Картофель фри", "Грибы", "Без дополнений" }, _builder.AddExtras);
    }

    private void ChooseMultipleOptions(string[] options, Action<string> addAction)
    {
        bool addMore;
        do
        {
            Console.WriteLine("Выберите вариант:");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > options.Length)
            {
                Console.WriteLine("Пожалуйста, выберите корректный вариант.");
            }

            addAction(options[choice - 1]);

            Console.WriteLine("Хотите добавить еще один вариант? (да/нет)");
            string response = Console.ReadLine().ToLower();
            addMore = response == "да" || response == "yes";
        } while (addMore);
    }

    public Shawarma GetShawarma()
    {
        return _builder.GetShawarma();
    }
}

// Основной класс для демонстрации
public class Program
{
    public static void Main()
    {
        var customBuilder = new CustomShawarmaBuilder();
        var director = new ShawarmaDirector(customBuilder);

        director.MakeCustomShawarma();

        Shawarma customShawarma = director.GetShawarma();
        Console.WriteLine(customShawarma);
    }
}