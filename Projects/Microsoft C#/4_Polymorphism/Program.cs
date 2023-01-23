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
            // Polymorphism at work #1: a Rectangle, Triangle and Circle
            // can all be used whenever a Shape is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class.
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            foreach (var s in shapes)
            {
                s.Draw();
            }
            /*
                Drawing rectangle...
                Performing base class drawing tasks
                Drawing triangle...
                Performing base class drawing tasks
                Drawing circle...
                Performing base class drawing tasks
            */

            DerivedClass B = new DerivedClass();
            B.DoWork(); // Calls the new method

            BaseClass A = B;
            A.DoWork(); // Also calls the new method

            DerivedClass2 B2 = new DerivedClass2();
            B2.DoWork(); // Calls the new method

            BaseClass2 A2 = (BaseClass2)B2;
            A2.DoWork(); // Calls the old method
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
        public override void Draw()
        {
            Console.WriteLine("Drawing circle...");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle...");
            base.Draw();
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing triangle...");
            base.Draw();
        }
    }

    public class BaseClass
    {
        public virtual void DoWork() { }
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void DoWork() { }
        public override int WorkProperty
        {
            get { return 0; }
        }
    }
    
    // Hide base class members with new members
    public class BaseClass2
    {
        public virtual void DoWork() { WorkField++; }
        public int WorkField;
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClass2 : BaseClass2
    {
        public override void DoWork() { WorkField++; }
        public int WorkField;
        public override int WorkProperty
        {
            get { return 0; }
        }
    }

    // Prevent derived classes from overriding virtual members
    public class A
    {
        public virtual void DoWork() { }
    }
    public class B : A
    {
        public override void DoWork() { }
    }
    public class C : B
    {
        public sealed override void DoWork() { }
    }
    public class D : C
    {
        public new void DoWork() { }
    }

    public class Base
    {
        public virtual void DoWork() { /*...*/ }
    }
    public class Derived : Base
    {
        public override void DoWork()
        {
            // Perform Derived's work here
            // ...
            // Call DoWork on base class
            base.DoWork();
        }
    }
}