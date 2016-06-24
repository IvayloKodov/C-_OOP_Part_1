using System;

public class Number
{
    public int num;
    public bool isPrime;

    public Number(int num)
    {
        this.num = num;
        if (PrimeChecker.CheckIfNumberIsPrime(num))
        {
            this.isPrime = true;
        }
        else
        {
            this.isPrime = false;
        }
    }

    public Number NextPrimeNumber(int n)
    {
        Number nextNumber = new Number(n);
        return nextNumber;
    }
}
class PrimeChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Number firstNumber = new Number(n);
        Number secondNumber = new Number(FindNextPrimeNumber(n));
        Console.Write("{0}, ", secondNumber.num);
        if (firstNumber.isPrime)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
    public static int FindNextPrimeNumber(int number)
    {
        while (true)
        {
            bool isPrime = true;
            number = number + 1;

            int squaredNumber = (int)Math.Sqrt(number);

            for (int i = 2; i <= squaredNumber; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                return number;
        }
    }
    public static bool CheckIfNumberIsPrime(int number)
    {
        bool result = true;
        if (number == 0 || number == 1)
        {
            result = true;
        }

        int squaredNumber = (int)Math.Sqrt(number);
        for (int i = 2; i < squaredNumber; i++)
        {
            if (number % i == 0)
            {
                result = false;
                break;
            }
        }
        return result;
    }
}