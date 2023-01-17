using System;
using System.Linq;

// Revise reference types, do it on another namespace

namespace TypeSystemInCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Microsoft C# reference");
            Console.WriteLine("Section: Type system");
            Console.WriteLine("===============================\n\n\n");


            AllCodes sourceCode = new AllCodes();
            Continuation sourceCode2 = new Continuation();
            Cont continue2 = new Cont();
            Continue @continue = new Continue();


            Console.ReadKey();
        }
    }

    public class AllCodes
    {
        public AllCodes()
        {
            int a = 5;
            int b = a + 2; // OK

            bool test = true;

            // Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
            // int c = a + test;

            // Specifying types in variable declarations
            float temperature;
            string name;
            Test test1 = new Test();

            // Declarations with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;

            Console.WriteLine(query); // System.Linq.Enumerable+WhereArrayIterator`1[System.Int32]
            GetName(13213);
        }

        public string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            else
                return String.Empty;
        }
        private string[] names = { "Spenser", "Sally", "Doug" };
    }

    public class Test
    {
        public Test()
        {
            Console.WriteLine("This is test class");
        }
    }

    // Built-in types like string and object types.
    
    public class Continuation : AllCodes
    {
        public Continuation()
        {
            Console.WriteLine("\nThis is the continuation or extended version of " + nameof(Continuation) + " class.");
            byte b = byte.MaxValue;
            byte num = 0xA;
            int i = 5;
            char c = 'Z';
            Console.WriteLine(b + "\n" + num + "\n" + i + "\n" + c + "\n");

            Coords coords = new Coords(1, 2); // coordinates in x and y Axis
            FileMode open = FileMode.Open;
            FileMode append = FileMode.Append;
            Console.WriteLine(open);
            Console.WriteLine(append);
        }
    }

    // Custom types like struct, class, interface, enum, and record constructs to create your own custom types
    public struct Coords
    {
        public int x, y;

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    public enum FileMode
    {
        CreateNew = 1,
        Create = 2,
        Open = 3,
        OpenOrCreate = 4,
        Truncate = 5,
        Append = 6
    }

    // Reference types 
    public class Cont : Continuation
    {
        public Cont()
        {
            Console.WriteLine("\nContinuation of Continuation Class...");
            TestClass test = new TestClass();
            TestClass test2 = test;

            // Re-do this section with manipulating classes with interfaces by reference types 
            // TestClass test3 = new TestClass();
            // Declare and assign using an existing value.
            // IMyInterface myInterface = test3;
            // Or create and assign a value in a single statement.
            // IMyInterface myInterface2 = new TestClass();

            int[] nums = { 1, 2, 3, 4, 5 };
            int len = nums.Length;
            Console.WriteLine("Length of array: " + len);
        }
    }
    class TestClass { }
    interface IMyInterface { }
    
    // Types of literal values
    public class Continue : Cont
    {
        public Continue()
        {
            Console.WriteLine("\nThis is continuation of Cont class...");
            // Types of literal values
            string s = "The answer is " + 5.ToString();
            // Outputs: "The answer is 5"
            Console.WriteLine(s);

            Type type = 12345.GetType();
            // Outputs: "System.Int32"
            Console.WriteLine(type);

            // Generic Types
            List<string> stringList = new List<string>();
            stringList.Add("String example");
            // compile time error adding a type other than a string
            // stringList.Add(4);

            {
                // Implicit types, anonymous types, and nullable value types
                // i is compiled as an int
                var i = 5;

                // s is compiled as a string
                var str = "C# implicit types, anonymous types, and nullable value types";

                // a is compiled as int[]
                var a = new[] { 0, 1, 2 };

                // expr is compiled as IEnumerable<Customer>
                // or perhaps IQueryable<Customer>
                var customers = new[] {""};
                var expr =
                    from c in customers
                    where c.City == "London"
                    select c;
            }


        }
    }
}

