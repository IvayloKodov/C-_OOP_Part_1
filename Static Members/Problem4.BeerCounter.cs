using System;
using System.Linq;

public class BeerCounter
{
    private static int beerInStock;
    private static int beersDrankCount;

    public static int BeerInStock
    {
        get { return beerInStock; }
        set { beerInStock = value; }
    }

    public static int BeersDrankCount
    {
        get { return beersDrankCount; }
        set { beersDrankCount = value; }
    }

    public static void BuyBeer(int bottlesCount)
    {
        BeerInStock += bottlesCount;
    }
    public static void DrinkBeer(int bottlesCount)
    {
        BeersDrankCount += bottlesCount;
        BeerInStock -= bottlesCount;
    }
}

public class Launcher
{
    public static void Main()
    {
        string input = Console.ReadLine();
        while (input != "End")
        {
            int[] buyBeerCounts = input.Split().Select(int.Parse).ToArray();
            BeerCounter.BuyBeer(buyBeerCounts[0]);
            BeerCounter.DrinkBeer(buyBeerCounts[1]);

            input = Console.ReadLine();
        }
        Console.WriteLine("{0} {1}", BeerCounter.BeerInStock, BeerCounter.BeersDrankCount);
    }
}