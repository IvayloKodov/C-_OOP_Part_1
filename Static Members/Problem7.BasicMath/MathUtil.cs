namespace Problem7.BasicMath
{
    public class MathUtil
    {
        public static double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static double Substract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double number, double divisor)
        {
            return number / divisor;
        }

        public static double Percentage(double number, double percent)
        {
            return number * (percent / 100);
        }
    }
}