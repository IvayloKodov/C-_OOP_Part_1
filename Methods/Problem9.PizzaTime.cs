using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

public class Pizza
{
    public static SortedDictionary<int, List<string>> pizzasByGroups = new SortedDictionary<int, List<string>>();
    public string name;
    public int group;

    public Pizza(int group, string name)
    {
        this.@group = group;
        this.name = name;
    }

    public static SortedDictionary<int, List<string>> GetPizzas(params int[] groups)
    {
        if (groups.Length == 0)
        {
            return Pizza.pizzasByGroups;
        }
        SortedDictionary<int, List<string>> selectGroups = new SortedDictionary<int, List<string>>();
        foreach (var @group in groups)
        {
            List<string> pizzas = Pizza.pizzasByGroups[group];
            selectGroups.Add(group, pizzas);
        }
        return selectGroups; ;
    }

    public static void PrintPizzas()
    {
        foreach (var pizzasByGroup in pizzasByGroups)
        {
            Console.WriteLine($"{pizzasByGroup.Key} - {string.Join(", ", pizzasByGroup.Value)}");
        }
    }
}

public class PizzaTime
{
    public static void Main()
    {
        MethodInfo[] methods = typeof(Pizza).GetMethods();
        bool containsMethod = methods.Any(m => m.ReturnType.Name.Equals("SortedDictionary`2"));
        if (!containsMethod)
        {
            throw new Exception();
        }

        string[] rawPizzas = Console.ReadLine().Split();
        string pattern = @"(\d+)(\w+)";
        Regex regex = new Regex(pattern);

        for (int i = 0; i < rawPizzas.Length; i++)
        {
            Match match = regex.Match(rawPizzas[i]);
            var pizza = new Pizza(int.Parse(match.Groups[1].Value), match.Groups[2].Value);
            if (!Pizza.pizzasByGroups.ContainsKey(int.Parse(match.Groups[1].Value)))
            {
                Pizza.pizzasByGroups.Add(int.Parse(match.Groups[1].Value), new List<string>());
            }
            Pizza.pizzasByGroups[int.Parse(match.Groups[1].Value)].Add(match.Groups[2].Value);
        }
        Pizza.PrintPizzas();
    }
}