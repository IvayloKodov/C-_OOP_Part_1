using System;
using System.Linq;
using System.Reflection;

namespace Problem1.ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        //Surface Area = 2lw + 2lh + 2wh
        public double SurfaceArea()
        {
            double surfArea = 2 * this.length * (this.width + this.height) + 2 * this.width * this.height;
            return surfArea;
        }
        //Lateral Surface Area = 2lh + 2wh
        public double LateralSurfaceArea()
        {
            double latSurfArea = 2 * this.height * (this.length + this.width);
            return latSurfArea;
        }
        //Volume = lwh
        public double Volume()
        {
            double volume = this.length * this.width * this.height;
            return volume;
        }
    }
    public class ClassBox
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = new Box(length, width, height);
            Console.WriteLine("Surface Area - {0:F2}", box.SurfaceArea());
            Console.WriteLine("Lateral Surface Area - {0:F2}", box.LateralSurfaceArea());
            Console.WriteLine("Volume - {0:F2}", box.Volume());
        }
    }
}
