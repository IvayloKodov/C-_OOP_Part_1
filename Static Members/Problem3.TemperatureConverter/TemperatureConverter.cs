using System;

public class TemperatureConverter
{
    public static void Main()
    {
        string input = Console.ReadLine();
        while (input != "End")
        {
            string[] tempInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int temperature = int.Parse(tempInfo[0]);
            string metric = tempInfo[1];
            if (metric == "Celsius")
            {
                Console.WriteLine("{0:F2} Fahrenheit", FahrenheitConverter(temperature));
            }
            else
            {
                Console.WriteLine("{0:F2} Celsius", CelsiusConverter(temperature));
            }
            input = Console.ReadLine();
        }
    }

    public static double FahrenheitConverter(int temperature)
    {
        double fahrenheit = temperature * 1.8 + 32;
        return fahrenheit;
    }

    public static double CelsiusConverter(int temperature)
    {
        double celsius = (temperature - 32) / 1.8;
        return celsius;
    }
}