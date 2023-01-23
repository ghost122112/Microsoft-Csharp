using System;

namespace GenericClassesAndMethods
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


            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");

            // Declare a list of type ExampleClass
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());


            Console.WriteLine("\n\n\n\n\n\n\n\n\nPress any key...");
            Console.ReadKey(true);
        }
    }

    public class GenericList<T>
    {
        public void Add(T input) { }
    }

    public class ExampleClass
    {
        public ExampleClass()
        {
            Console.WriteLine("Hello C#");
        }
    }

    // type parameter T in angle brackets
    public class GenericLisT<T>
    {
        public class Node
        {
            // T used in non-generic constructor.
            public Node(T t)
            {

            }
            private Node? next;
            public Node? Next
            {
                get { return next; }
                set { next = value; }
            }

            // T as private member data type.
            private T data;

            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        private Node? head;

        // constructor
        public GenericLisT()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    public class TestGenericList
    {
        public TestGenericList()
        {
            // int is the type argument
            GenericLisT<int> list = new GenericLisT<int>();

            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            foreach (int i in list)
            {
                System.Console.WriteLine(i + " ");
            }
            System.Console.WriteLine("\nDone");
        }
    }
}
