using System;
using SourceCode;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");

            SourceCodePolymorphism sourceCode = new SourceCodePolymorphism();

            Console.WriteLine("\n\n\n\n\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class SourceCodePolymorphism
    {
        public SourceCodePolymorphism()
        {
            Shape shape = new Shape();
            Circle circle = new Circle();
            circle.Draw();
        }
    }

    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }

    }

    public class Circle : Shape
    {
        private double _Radius { get; set; }
        
        public override void Draw()
        {
            Console.WriteLine("Drawing circle...");
            base.Draw();
            Circle circle = new Circle(10);
        }
        public Circle()
        {

        }
        public Circle(double r)
        {
            this._Radius = r;
            const double PI = Math.PI;
            double Area;

            Area = PI * Math.Pow(r, 2);
            Console.WriteLine($"Area of circle: {Area}");
        }
    }
}