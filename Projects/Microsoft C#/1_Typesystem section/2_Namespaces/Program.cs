using System;
using SampleNamespace;
using SourceCode;

namespace Namespaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NamespacesClass namespacesClass = new NamespacesClass("Hello C#\n");
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

            // Below this line all source code is provided
            System.Console.WriteLine("Hello C#!\n"); // Hello C#!

            SampleClass sampleClass = new SampleClass();
            sampleClass.SampleMethod();

        }
    }
}

namespace SampleNamespace
{
    public class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
                "SampleMethod inside SampleNamespace");

            AnotherSampleClass sampleClass = new AnotherSampleClass();
            sampleClass.AnotherSampleMethod();
            global::System.Console.WriteLine("Hello World!\n"); // much deeper namespaces
        }
    }

    public class AnotherSampleClass
    {
        public void AnotherSampleMethod()
        {
            System.Console.WriteLine(
                "AnotherSampleMethod inside SampleNamespace");
        }
    }
}