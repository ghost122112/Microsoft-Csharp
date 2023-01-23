using System;
using System.Net.WebSockets;
using SourceCode;

namespace Objects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");

            Console.WriteLine("""
                ================================
                    Microsoft C# reference
                ================================


                """);

            ObjectsSourceCode sourceCode = new ObjectsSourceCode();


            Console.WriteLine("\n\n\n\n\n\n\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class ObjectsSourceCode
    {
        public ObjectsSourceCode()
        {
            Person john = new Person("John", 25);

            Person person1 = new Person("Leopold", 6);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

            // Declare new person, assign person1 to it.
            Person person2 = person1;

            // Change the name of person2, and person1 also changes:
            person2.Name = "John";
            person2.Age = 30;

            Console.WriteLine($"Name: {person1.Name}\nAge: {person1.Age}");
            Console.WriteLine($"Name: {person2.Name}\nAge: {person2.Age}");
            // Outputs are the same.

            // Structs
            PersonStruct p1 = new PersonStruct("Alex", 19);
            PersonStruct p2 = p1;

            p2.Name = "Kennedi";
            p2.Age = 30;

            Console.WriteLine($"Name: {p2.Name}\nAge: {p2.Age}");

            if (person2.Equals(person1))
                Console.WriteLine("person2 has the same values as person1");
        }
    }
    // Structs
    public struct PersonStruct
    {
        public string Name;
        public int Age;
        public PersonStruct(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Console.WriteLine("Empty constructor!");
        }
        public Person(string name)
        {
            this.Name = name;
            Console.WriteLine($"Name: {name}\nAge: {null}");
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            Console.WriteLine($"Name: {name}\nAge: {age}");
        }
        // Other properties, methods, events...
    }
}
