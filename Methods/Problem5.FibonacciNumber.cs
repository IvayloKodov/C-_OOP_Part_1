using System;
using System.Collections.Generic;
using System.Numerics;

public class Fibonacci
{
    public List<BigInteger> fibonacciNumbers;

    public Fibonacci(List<BigInteger> fibonacciNumbers)
    {
        this.fibonacciNumbers = fibonacciNumbers;
    }

    public List<BigInteger> GetNumbersInRange(int startPosition, int endPosition)
    {
        return this.fibonacciNumbers.GetRange(startPosition, endPosition - startPosition);
    }
}

public class FibonacciNumber
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int stop = int.Parse(Console.ReadLine());
        var fibNumbers = FibonacciFiller(stop);
        Fibonacci fibonacci = new Fibonacci(fibNumbers);
        Console.WriteLine("{0}", string.Join(", ", fibonacci.GetNumbersInRange(start, stop)));
    }

    public static List<BigInteger> FibonacciFiller(int x)
    {
        var fibs = new List<BigInteger>();

        BigInteger prev = -1;
        BigInteger next = 1;
        for (int i = 0; i < x; i++)
        {
            BigInteger sum = prev + next;
            prev = next;
            next = sum;
            fibs.Add(sum);
        }
        return fibs;
    }
}