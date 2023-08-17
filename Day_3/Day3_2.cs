using System;

namespace ShapeHierarchy
{
    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
        }
    }

    class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Shape: Rectangle");
            Console.WriteLine($"Width: {Width}, Height: {Height}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
        }
    }

    class Triangle : IShape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public double CalculatePerimeter()
        {
            // Assuming the triangle is an isosceles triangle for simplicity
            double hypotenuse = Math.Sqrt(Base * Base + Height * Height);
            return Base + 2 * hypotenuse;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Shape: Triangle");
            Console.WriteLine($"Base: {Base}, Height: {Height}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);
            Triangle triangle = new Triangle(5, 8);

            circle.DisplayDetails();
            Console.WriteLine();
            rectangle.DisplayDetails();
            Console.WriteLine();
            triangle.DisplayDetails();
        }
    }
}
