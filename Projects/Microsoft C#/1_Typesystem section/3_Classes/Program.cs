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
        }
    }
}