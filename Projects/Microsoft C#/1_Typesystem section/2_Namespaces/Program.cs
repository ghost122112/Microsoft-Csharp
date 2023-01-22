using System;

namespace Namespaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }
    }
}

namespace SourceCode
{
    public class NamespacesClass
    {
        private string _message { get; set; }
        public NamespacesClass(string message)
        {
            _message = message;
            Console.WriteLine(message);


        }
    }
}