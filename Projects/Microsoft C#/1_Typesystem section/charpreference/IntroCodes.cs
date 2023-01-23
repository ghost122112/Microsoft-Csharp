using System;

namespace charpreference
{
    public class IntroCodes
    {
        public IntroCodes()
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
        }
    }
}