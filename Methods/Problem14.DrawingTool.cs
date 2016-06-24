using System;

public abstract class Shape
{
    public abstract void Draw();
}
public class Square : Shape
{
    public int side;

    public Square(int side)
    {
        this.side = side;
    }

    public override void Draw()
    {
        Console.WriteLine("{0}{1}{0}", "|", string.Join(" ", new string('-', this.side)));
        for (int i = 0; i < this.side - 2; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', this.side));
        }
        Console.WriteLine("{0}{1}{0}", "|", string.Join(" ", new string('-', this.side)));
    }
}

public class Rectangle : Shape
{
    public int length;
    public int width;

    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    public override void Draw()
    {
        Console.WriteLine("{0}{1}{0}", "|", string.Join(" ", new string('-', this.length)));
        for (int i = 0; i < this.width - 2; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', this.length));
        }
        Console.WriteLine("{0}{1}{0}", "|", string.Join(" ", new string('-', this.length)));
    }
}

public class CorDraw
{
    public Shape shape;
    public CorDraw(Shape shape)
    {
        this.shape = shape;
    }

    public void Draw()
    {
        this.shape.Draw();
    }
}
public class DrawingTool
{
    public static void Main()
    {
        string shape = Console.ReadLine();

        if (shape == "Square")
        {
            int side = int.Parse(Console.ReadLine());
            Square square = new Square(side);
            CorDraw corDraw = new CorDraw(square);
            corDraw.Draw();
        }
        else
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(length, width);
            CorDraw corDraw = new CorDraw(rectangle);
            corDraw.Draw();
        }
    }
}