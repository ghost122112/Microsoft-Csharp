using SourceCode;
using System;

namespace Classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");
            Console.WriteLine("""
                =================================
                      Microsoft C# reference     
                =================================


                """);

            string triangle = """
                |\
                | \
                |  \
                |___\

                """;
            Console.WriteLine(triangle + "\nThis is triangle :)");

            ClassesSourceCode classes = new ClassesSourceCode("""

                =================================
                           1.3. Classes           
                =================================

                """);

            

            // Call the constructor that has no parameters.
            var person1 = new Person();
            Console.WriteLine(person1.Name);

            // Call the constructor that has one parameter.
            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            // Get the string representation of the person2 instance
            Console.WriteLine(person2);
            
            // Output:
            // unknown
            // Sarah Jones
            // Sarah Jones


            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class ClassesSourceCode
    {
        private string _message { get; set; }

        public ClassesSourceCode(string message)
        {
            _message = message;
            Console.WriteLine(message);

            // Below this line all source code will be placed

            /* Introduction to classes */

            // Reference types

            // Declaring an object type of type MyClass.
            MyClass myClass = new MyClass();

            // Declaring another object of the same type, assigning it the value of the first object.
            MyClass myClass2 = myClass;


            // Creating objects

            Customer object1 = new Customer();
            
            Customer object2;

            Customer object3 = new Customer();
            Customer object4 = object3;

            // Class inheritance

        }
    }

    public class Person
    {
        // Auto-implemented readonly property
        public string Name { get; set; }

        // Constructor
        public Person()
        {
            Name = "unknown";
        }

        // Constructor takes one argument
        public Person(string name)
        {
            Name = name;
        }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }

    public class Employee
    {

    }

    public class Manager : Employee
    {
        // Employee fields, properties, methods and events are inherited
        // New Manager fields, properties, methods and events go here...
    }

    public class MyClass
    {
        public MyClass()
        {

        }
    }

    //[access modifier] - [class] - [identifier]
    public class Customer
    {
        public Customer()
        {

        }
    }
}