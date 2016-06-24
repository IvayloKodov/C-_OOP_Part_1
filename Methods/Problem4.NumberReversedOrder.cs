using System;
using System.Linq;

public class DecimalNumber
{
    public decimal number;

    public DecimalNumber(decimal number)
    {
        this.number = number;
    }

    public void PrintReversed()
    {
        string numberString = this.number.ToString();
        var reversedNumber = numberString.ToCharArray().Reverse().ToArray();
        Console.WriteLine(reversedNumber);
    }
}

public class NumberReversedOrder
{
    public static void Main()
    {
        decimal inputNumber = decimal.Parse(Console.ReadLine());
        DecimalNumber decimalNumber = new DecimalNumber(inputNumber);
        decimalNumber.PrintReversed();
    }
}