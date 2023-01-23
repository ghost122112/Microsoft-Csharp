using System;
using SourceCode;

namespace Records
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


            RecordsSourceCode classes = new RecordsSourceCode("""

                =================================
                           1.4. Records           
                =================================

                """);


            Console.WriteLine("\n\n\n\n\n\n");
            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class RecordsSourceCode
    {
        private string _message { get; set; }

        public RecordsSourceCode(string message)
        {
            this._message = message;
            Console.WriteLine(message);

            // Below this line will be all the code about records

            /*
            # When to use records?    
            Consider using a record in place of a class or struct in the following scenarios:
              * You want to define a data model that depends on value equality.
              * You want to define a type for which objects are immutable.
            */

            Person person = new Person("Nancy", "Davolio");
            Console.WriteLine(person); // Outputs: Person { FirstName = Nancy, LastName = Davolio }

            // You can declare it like this as well:
            Person anotherPerson = new("John", "Jones");
            Console.WriteLine(anotherPerson); // Outputs: Person { FirstName = John, LastName = Jones }

            
            var phoneNumbers = new string[2];
            Student student1 = new("Nancy", "Davolio", phoneNumbers);
            Student student2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(student1 == student2); // output: True

            student1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(student1 == student2); // output: true

            Console.WriteLine(ReferenceEquals(student1, student2)); // output: False


            PersonRecord person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);
            // output: PersonRecord { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

            PersonRecord person2 = person1 with { FirstName = "John" };
            Console.WriteLine(person2);
            // output: PersonRecord { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: PersonRecord { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
        }
    }

    public record Person(string FirstName, string LastName);
    public record Student(string FirstName, string LastName, string[] PhoneNumbers);
    public record PersonRecord(string FirstName, string LastName)
    {
        public string[] PhoneNumbers { get; init; }
    }
}