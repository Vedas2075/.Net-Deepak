namespace Inheritance;

public interface I2DShape
{
    public double GetArea();
    public double GetPerimeter();    
}

public interface IHaveDiagonal
{
    public double GetDiagonal();
}

public abstract class Shape
{
    public void PrintDetails(I2DShape shape)
    {
        Console.WriteLine($"This is {shape.GetType()}");
    }
}

public class Rectangle : Shape, I2DShape, IHaveDiagonal
{
    double length;
    double breadth;

    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }    

    public double GetArea() => length * breadth;
    public double GetPerimeter() => 2 * (length + breadth);
    public double GetDiagonal() => Math.Sqrt(length * length + breadth * breadth);
}

public class Square : Rectangle
{       
    public Square(double side) : base(side, side)
    {
    }
}

public class Circle: Shape, I2DShape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double GetArea() => Math.PI * radius * radius;
    public double GetPerimeter() => 2 * Math.PI * radius;
}


