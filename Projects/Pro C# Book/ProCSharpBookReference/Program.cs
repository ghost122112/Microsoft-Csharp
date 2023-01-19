using CoreCSharp;
using System;
using System.Collections.Generic;
using System.Numerics;
// using static System.Console; // by this command you can get rid of using Console.WriteLine() instead you cam use WriteLine();

namespace ProCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=======================");
            Console.WriteLine(" PRO C# Reference Book ");
            Console.WriteLine("=======================\n\n");

            Console.WriteLine("* Declaring variables\r\n* Initialization and scope of variables\r\n* Working with redefined C# data types\r\n* Dictating execution flow within a C# program\r\n* Organizing classes and types with namespaces\r\n* Getting to know the Main method\r\n* Using internal comments and documentation features\r\n* Using preprocessor directives\r\n* Understanding guidelines and conventions for good programming in C#\n\n\n\n\n");

            Variables lesson1 = new Variables();

            Console.WriteLine("\n\n\n\n\nPress any key to finish execution of a program...");
            Console.ReadKey();
        }
    }
}

// Chapter-2: Core C# 

namespace CoreCSharp
{
    public class Variables
    {
        public Variables()
        {
            Console.WriteLine("Hello I am from DeclaringVariables class\n");

            /* Working with variables */
            /*============================================*/
            {
                // First declaring then initializing: 
                int i;
                i = 10;

                // Simultaneously, declaring and initializing:
                int j = 10;

                // You can also write like this:
                int v, k, l;
                int a, b = 10;
                int c = 5, d = 15;

                // This won't compile:
                //int x = 10, bool y = true;
                // Instead write like this:
                int x = 10;
                bool y = true;
            }
            /*============================================*/

            /* Initializing Variables */
            /*============================================*/
            {
                // Not allowed to write like this, won't compile:
                // int e;
                // Console.WriteLine(e);
            }
            /*============================================*/

            /* Using Type Inference */
            /*============================================*/
            {
                var name = "Bugs Bunny";
                var age = 25;
                var isRabbit = true;
                Type nameType = name.GetType();
                Type ageType = age.GetType();
                Type isRabbitType = isRabbit.GetType();
                Console.WriteLine($"name is of type: {nameType}");
                Console.WriteLine($"age is of type: {ageType}");
                Console.WriteLine($"isRabbit is of type: {isRabbitType}");
            }
            /*============================================*/

            /* Understanding Variables Scope */
            /*============================================*/
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
                // We can declare a variable named i again, because
                // there's no other variable with that name in scope
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            }

            {
                // Scope Clashes for Fields and Local Variables
                Method();
            }
            /*============================================*/

            /* Working with Constants */
            /*============================================*/
            {
                const int a = 10; // constant variables, meaning it will never be changed
                Console.WriteLine("Constant variable: " + a.GetType());
            }
            /*============================================*/

            /* Using Predefined Data Types */
            /*============================================*/
            {
                // Value Types and Reference Types
                Vector x, y;
                x = new Vector();
                x.Value = 30;
                y = x;
                Console.WriteLine(y.Value);
                y.Value = 50;
                Console.WriteLine(x.Value);
            }
            /*============================================*/

            /* .NET Types */
            /*============================================*/
            {
                int i = 100;
                string s = i.ToString();
                Console.WriteLine(s.GetType() + "\n\n\n"); // System.String
            }
            /*============================================*/

            /* Predefined Value Types */
            /*============================================*/
            {                
                List<string> types = new List<string>
                {
                    $"NAME    |   .NET TYPE       |   DESCRIPTION            |   RANGE(MIN:MAX)",
                    $"sbyte   |   System.SByte    |   8-bit signed integer   |   {sbyte.MinValue}:{sbyte.MaxValue}",
                    $"short   |   System.Int16    |   16-bit signed integer  |   {short.MinValue}:{short.MaxValue}",
                    $"int     |   System.Int32    |   32-bit signed integer  |   {int.MinValue}:{int.MaxValue}",
                    $"long    |   System.Int64    |   64-bit signed integer  |   {long.MinValue}:{long.MaxValue}",
                    $"byte    |   System.Byte     |   8-bit signed integer   |   {byte.MinValue}:{byte.MaxValue}",
                    $"ushort  |   System.UInt16   |   16-bit signed integer  |   {ushort.MinValue}:{ushort.MaxValue}",
                    $"uint    |   System.UInt32   |   32-bit signed integer  |   {uint.MinValue}:{uint.MaxValue}",
                    $"ulong   |   System.UInt64   |   64-bit signed integer  |   {ulong.MinValue}:{ulong.MaxValue}"
                };

                Console.WriteLine(types[1] + "\n");

                for (int i = 0; i < types.Count; i++)
                {
                    Console.WriteLine(types[i]);
                }
            }
            /*============================================*/
        }

        public class Vector
        {
            public int Value { get; set; }
        }


        // Scope Clashes for Fields and Local Variables
        static int j = 20; // this won't print to the console
        static void Method()
        {
            Console.WriteLine(Variables.j); // And now it is going to be printed
            int j = 30;
            Console.WriteLine(j);
            return;
        }
    }
}