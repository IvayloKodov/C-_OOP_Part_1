using System;

namespace Problem7.BasicMath
{
    
    public class BasicMath
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] mathInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string mathOperation = mathInfo[0];
                double firstNumber = double.Parse(mathInfo[1]);
                double secondNumber = double.Parse(mathInfo[2]);
             
                switch (mathOperation)
                {
                    case "Sum":
                        Console.WriteLine("{0:F2}", MathUtil.Sum(firstNumber, secondNumber));
                        break;
                    case "Subtract":
                        Console.WriteLine("{0:F2}", MathUtil.Substract(firstNumber, secondNumber));
                        break;
                    case "Multiply":
                        Console.WriteLine("{0:F2}", MathUtil.Multiply(firstNumber, secondNumber));
                        break;
                    case "Divide":
                        Console.WriteLine("{0:F2}", MathUtil.Divide(firstNumber, secondNumber));
                        break;
                    case "Percentage":
                        Console.WriteLine("{0:F2}", MathUtil.Percentage(firstNumber, secondNumber));
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}