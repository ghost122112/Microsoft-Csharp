// Classes

using System;

namespace RecordsInCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Declaring an object of type MyClass.
            MyClass mc = new MyClass();

            // Declaring another object of the same type, assigning it the value of the first object.
            MyClass mc2 = mc;

            Console.WriteLine(mc); // RecordsInCsharp.MyClass
            Console.WriteLine(mc2); // RecordsInCsharp.MyClass

            // Creating objects
            Customer object1 = new Customer();
        }
    }
    
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass mehtod of MyClass class inside RecordsInCsharp namespace");
        }
    }
    
    //[access modifier] - [class] - [identifier]
    public class Customer
    {
        // Fields, properties, methods, and events go here
        public Customer()
        {
            Console.WriteLine("That is customer class constructor method");
        }
    }

    // class inheritance
    public class Mai
}
