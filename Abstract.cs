using System;

// Abstract base class
public abstract class Shape
{
    public abstract double CalculateArea();
}

// Derived class for Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Derived class for Rectangle
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a shape to calculate area:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");
        }
        else if (choice == 2)
        {
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():F2}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
