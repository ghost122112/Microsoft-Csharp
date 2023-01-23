using System;
using SourceCode;

namespace Interfaces
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


            InterfacesSourceCode classes = new InterfacesSourceCode("""

                =================================
                         1.5. Interfaces         
                =================================

                """);


            Console.WriteLine("\n\n\n\n\n\n");
            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class InterfacesSourceCode
    {
        private string _message { get; set; }

        public InterfacesSourceCode(string message)
        {
            _message = message;
            Console.WriteLine(message);

            // All the code about interfaces will be below this line

            Car car = new Car();
        }
    }
    /* Interfaces - define behavior for multiple types */

    interface IEqutable<T>
    {
        bool Equals(T obj);
    }

    public class Car : IEquatable<Car>
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }

        // Implementation of IEquatable<T> interface
        public bool Equals(Car? car)
        {
            return (this.Make, this.Model, this.Year) ==
                (car?.Make, car?.Model, car?.Year);
        }
    }

}
