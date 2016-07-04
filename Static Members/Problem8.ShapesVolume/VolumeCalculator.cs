using System;

namespace Problem8.ShapesVolume
{
    public class VolumeCalculator
    {
        public static double TriangularPrism(TriangularPrism triangularPrism)
        {
            double volume = (triangularPrism.BaseSide * triangularPrism.Height * triangularPrism.Length)/2;
            return volume;
        }

        public static double Cube(Cube cube)
        {
            double volume = Math.Pow(cube.Side, 3);
            return volume;
        }

        public static double Cylinder(Cylinder cylinder)
        {
            double volume = Math.PI * Math.Pow(cylinder.Radius, 2) * cylinder.Height;
            return volume;
        }
    }
}