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

            OverviewClass overview = new OverviewClass("""

                =================================
                         1.1. Overview           
                =================================

                """);
            

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

