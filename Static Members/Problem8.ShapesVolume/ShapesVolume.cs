using System;
using Problem8.ShapesVolume;

public class ShapesVolume
{
    public static void Main()
    {
        string input = Console.ReadLine();
        while (input != "End")
        {
            string[] figureInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string figure = figureInfo[0];
            switch (figure)
            {
                case "Cube":
                    Cube cube = new Cube(double.Parse(figureInfo[1]));
                    Console.WriteLine($"{VolumeCalculator.Cube(cube):F3}");
                    break;
                case "Cylinder":
                    Cylinder cylinder = new Cylinder(double.Parse(figureInfo[1]), double.Parse(figureInfo[2]));
                    Console.WriteLine($"{VolumeCalculator.Cylinder(cylinder):F3}");
                    break;
                case "TrianglePrism":
                    double baseSide = double.Parse(figureInfo[1]);
                    double height = double.Parse(figureInfo[2]);
                    double length = double.Parse(figureInfo[3]);
                    TriangularPrism triangularPrism = new TriangularPrism(baseSide, height, length);
                    Console.WriteLine($"{VolumeCalculator.TriangularPrism(triangularPrism):F3}");
                    break;
            }
            input = Console.ReadLine();
        }
    }
}