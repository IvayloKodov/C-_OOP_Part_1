using System;
using System.Linq;
using System.Reflection;

namespace Problem2.ClassBoxDataValidation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
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
    public class ClassBoxDataValidation
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine("Surface Area - {0:F2}", box.SurfaceArea());
                Console.WriteLine("Lateral Surface Area - {0:F2}", box.LateralSurfaceArea());
                Console.WriteLine("Volume - {0:F2}", box.Volume());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}