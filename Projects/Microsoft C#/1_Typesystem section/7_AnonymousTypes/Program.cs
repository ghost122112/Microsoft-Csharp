using System;
using System.Diagnostics;
using SourceCode;

namespace AnonymousTypes
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


            Console.WriteLine("""

                ==================================
                 1.5. Generic classes and methods            
                ==================================

                """);

            AnonymousTypesSourceCode sourceCode = new AnonymousTypesSourceCode();

            Console.WriteLine("\n\n\n\n\n\n\nPress any key to finish...");
            Console.ReadKey(true);

        }
    }
}

namespace SourceCode
{
    public class AnonymousTypesSourceCode
    {
        public AnonymousTypesSourceCode()
        {
            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following
            // statement to verify that their inferred types are int and string.
            Console.WriteLine(v.Amount + " " + v.Message); // 108 Hello

            Console.WriteLine(v.Amount.GetType() + "\n" + v.Message.GetType());
            // System.Int32
            // System.String

            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };
            
            foreach (var anon in anonArray)
            {
                Console.WriteLine(anon);
                // Outputs:
                // { name = apple, diam = 4 }
                // { name = grape, diam = 1 }
            }

            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 0.79 };
            Console.WriteLine(apple);
            // Outputs: { Item = apples, Price = 1,35 }
            Console.WriteLine(onSale);
            // Outputs: { Item = apples, Price = 0,79 }

            // Anonymous types do override the ToString method, concatenating the name and ToString output of every property surrounded by curly braces.
            var data = new { Title = "Hello", Age = 24 };
            Console.WriteLine(data);            // Outputs: { Title = Hello, Age = 24 }
            Console.WriteLine(data.ToString()); // Outputs: { Title = Hello, Age = 24 }
        }
    }
}