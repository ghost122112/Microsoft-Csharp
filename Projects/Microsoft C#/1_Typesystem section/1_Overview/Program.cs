using System;

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


            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class Overview
    {

    }
}