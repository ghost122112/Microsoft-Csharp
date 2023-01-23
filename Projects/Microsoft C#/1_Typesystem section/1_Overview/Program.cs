using System;
using System.Collections;
using SourceCode;

namespace Overview
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

            OverviewClass overview = new OverviewClass("""

                =================================
                         1.1. Overview           
                =================================

                """);

            MyClass myClass = new MyClass();

            Test test = new Test();


            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class OverviewClass
    {
        private string _message { get; set; }
        public OverviewClass(string message)
        {
            _message = message;
            Console.WriteLine($"""
                
                {message}
                """);

            // Below this line, all source code is provided relating to overview section in microsoft c# reference

            int x = 5;
            int y = x + 2; // OK

            bool test = true;

            // Error. Operator '+' cannot apllied to operands of type 'int' and 'bool'
            // int c = a + test;

            /* Specifying types in variable declarations */
            
            // Declaration only:
            float temperature;
            string name;
            MyClass myClass;

            // Declarations with initializers (four examples):
            char firstLetter = 'A';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;

            // Value types

            // constant field on type byte
            byte b = byte.MaxValue;

            byte num = 0xA;
            int i = 5;
            char c = 'Z';

            Tuple<byte, int, char> tuple = new Tuple<byte, int, char>(10, 100, 'Z');
            Console.WriteLine(tuple); // (10, 100, Z)
            Coords coords = new Coords(10, 100);
        }

        public string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            else
                return String.Empty;
        }
        private string[] names = { "Spencer", "Sally", "Doug" };

    }

    /* Structs */
    public struct Coords
    {
        public int _x, _y;

        public Coords(int x, int y)
        {
            this._x = x;
            this._y = y;

            Console.WriteLine("X coord: " + x);
            Console.WriteLine("Y coord: " + y);
        }
    }

    /* Enums */
    public enum FileMode
    {
        CreateNew = 1,
        Create = 2,
        Open = 3,
        OpenOrCreate = 4,
        Truncate = 5,
        Append = 6
    }

    /* Reference Types */

    // A type that is defined as a class, record, delegate, array, or interface is a reference type.
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass field...");
        }

    }

    public class Test
    {
        public Test()
        {
            void FirstType()
            {
                MyClass myClass = new MyClass();
                MyClass myClass2 = myClass;
            }

            void SecondType()
            {
                MyClass myClass = new MyClass();
               
                // Declare and assign using an existing value.
                IMyInterface myInterface = (IMyInterface)myClass;

                // Or create and assign a value in a single statement
                // IMyInterface myInterface2 = new MyClass();


            }

            // Types of literal values
            {
                string s = "The answer is " + 5.ToString();
                // Outputs: "The answer is 5"
                Console.WriteLine(s);

                Type type = 12345.GetType();
                // Outputs: "System.Int32"
                Console.WriteLine(type);
            }

            /* Generic Types */
            {
                List<string> stringList = new List<string>();
                stringList.Add("string example");
                // complie time error adding a type other than a string:
                // stringList.Add(4);
                foreach (var list in stringList)
                    Console.WriteLine(list);
            }

            /* Implicit types, anonymous types, and nullable value types */
            {
                string message = "This is a string of characters";

                object anotherMessage = "This is another string of characters";
                IEnumerable<char> someCharacters = "abcdefghijklmnopqrstuvwxyz";

                Console.WriteLine(message);
                Console.WriteLine(anotherMessage);
                Console.WriteLine(someCharacters);
            }
        }
    }
    
    // Interface declaration

    interface IMyInterface
    {
        
    }
}

// end of overview section
