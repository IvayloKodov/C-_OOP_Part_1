using System;
using System.Collections.Generic;
using System.Linq;

public class Rectangle
{
    public string id;
    public double width;
    public double height;
    public double x;
    public double y;

    public Rectangle(string id, double width, double height, double x, double y)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.x = x;
        this.y = y;
    }

    public bool Intersect(Rectangle firstRectangle)
    {
        bool intersects = this.x + width >= firstRectangle.x && this.y + height >= firstRectangle.y;
        return intersects;
    }
}

public class RectangleIntersection
{
    public static void Main()
    {
        double[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToArray();

        double numberOfRectangles = input[0];
        double numberOfChecks = input[1];
        var rectangles = new List<Rectangle>();
        for (int i = 0; i < numberOfRectangles; i++)
        {
            string[] rectangleInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string rectangleID = rectangleInfo[0];
            double rectangleWidth = double.Parse(rectangleInfo[1]);
            double rectangleHeight = double.Parse(rectangleInfo[2]);
            double rectangleX = double.Parse(rectangleInfo[3]);
            double rectangleY = double.Parse(rectangleInfo[4]);

            Rectangle rectangle = new Rectangle(rectangleID, rectangleWidth, rectangleHeight, rectangleX, rectangleY);
            rectangles.Add(rectangle);
        }
        for (int i = 0; i < numberOfChecks; i++)
        {
            string[] rectanglesId = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var firstRectangle = rectangles.First(r => r.id == rectanglesId[0]);
            var secondRectangle = rectangles.First(r => r.id == rectanglesId[1]);

            //Decide which is closer to coordinates 0,0 and became first
            if (firstRectangle.x <= secondRectangle.x && firstRectangle.y <= secondRectangle.y)
            {
                Console.WriteLine(firstRectangle.Intersect(secondRectangle).ToString().ToLower());
            }
            else
            {
                Console.WriteLine(secondRectangle.Intersect(firstRectangle).ToString().ToLower());
            }
        }
    }
}