using System;

namespace AbstractClassAndMethod
{
    // Abstract base class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }



    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(8); 
            Console.WriteLine($"Area of the circle: {circle.GetArea():F2}cm");

            Shape rect = new Rectangle(3, 5);
            Console.WriteLine($"Area of the rectangle: {rect.GetArea():F2}cm");
        }
    }
}
