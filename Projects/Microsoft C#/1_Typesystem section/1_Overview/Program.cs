using System;
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

            OverviewClass overview = new OverviewClass("This is the message that was written as the parameter of the overview object using class OverviewClass");
            

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
        }
    }
}