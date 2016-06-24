using System;

public class Number
{
    public int number;

    public Number(int number)
    {
        this.number = number;
    }

    public string Converter()
    {
        var lastDigit = this.number % 10;
        string result = string.Empty;
        switch (lastDigit)
        {
            case 0:
                result = "zero";
                break;
            case 1:
                result = "one";
                break;
            case 2:
                result = "two";
                break;
            case 3:
                result = "three";
                break;
            case 4:
                result = "four";
                break;
            case 5:
                result = "five";
                break;
            case 6:
                result = "six";
                break;
            case 7:
                result = "seven";
                break;
            case 8:
                result = "eight";
                break;
            case 9:
                result = "nine";
                break;
        }
        return result;
    }
}

public class LastDigitName
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Number number = new Number(n);
        Console.WriteLine(number.Converter());
    }
}