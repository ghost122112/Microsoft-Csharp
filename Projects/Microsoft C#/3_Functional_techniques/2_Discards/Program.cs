using System;
using SourceCode;
using Discards;
using System.Globalization;

namespace Discrads
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");

            DiscardsSourceCode sourceCode = new DiscardsSourceCode("""
                ==============================
                        Discards in C#
                ==============================
                """);

            Person p = new Person("John", "Quincy", "Adams", "Boston", "MA");

            // Deconstruct the person object
            var (fName, _, city, _) = p;
            Console.WriteLine($"Hello {fName} of {city}!");
            // The example displays the following output:
            //   Hello John of Boston!

            DiscardsSourceCode.Method("Start");


            Console.WriteLine("\n\n\n\n\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class DiscardsSourceCode
    {
        private string _Message { get; set; }

        public DiscardsSourceCode(string message)
        {
            _Message = message;
            Console.WriteLine(message);

            // Tuple and object deconstruction
            {
                var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

                Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");

                static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
                {
                    int population1 = 0, population2 = 0;
                    double area = 0;

                    if (name == "New York City")
                    {
                        area = 468.48;
                        if (year1 == 1960)
                        {
                            population1 = 7781984;
                        }
                        if (year2 == 2010)
                        {
                            population2 = 8175133;
                        }
                        return (name, area, year1, population1, year2, population2);
                    }

                    return ("", 0, 0, 0, 0, 0);
                }
                // The example displays the following output:
                // Population change, 1960 to 2010: 393,149
                
            }

            object?[] objects = { CultureInfo.CurrentCulture,
                                CultureInfo.CurrentCulture.DateTimeFormat,
                                CultureInfo.CurrentCulture.NumberFormat,
                                new ArgumentException(), null };

            foreach (var obj in objects)
                ProvidesFormatInfo(obj);

            static void ProvidesFormatInfo(object? obj) =>
                Console.WriteLine(obj switch
                {
                    IFormatProvider fmt => $"{fmt.GetType()} object",
                    null => "A null object reference: Its use could result in a NullReferenceException",
                    _ => "Some object type without format information"
                });
            // The example displays the following output:
            //    System.Globalization.CultureInfo object
            //    System.Globalization.DateTimeFormatInfo object
            //    System.Globalization.NumberFormatInfo object
            //    Some object type without format information
            //    A null object reference: Its use could result in a NullReferenceException


            // Call to methods with out parameters

            string[] dateStrings = {"05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
                      "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                      "5/01/2018 14:57:32.80 -07:00",
                      "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                      "Fri, 15 May 2018 20:10:57 GMT" };
            foreach (string dateString in dateStrings)
            {
                if (DateTime.TryParse(dateString, out _))
                    Console.WriteLine($"'{dateString}': valid");
                else
                    Console.WriteLine($"'{dateString}': invalid");
            }
            // The example displays output like the following:
            //       '05/01/2018 14:57:32.8': valid
            //       '2018-05-01 14:57:32.8': valid
            //       '2018-05-01T14:57:32.8375298-04:00': valid
            //       '5/01/2018': valid
            //       '5/01/2018 14:57:32.80 -07:00': valid
            //       '1 May 2018 2:57:32.8 PM': valid
            //       '16-05-2018 1:00:32 PM': invalid
            //       'Fri, 15 May 2018 20:10:57 GMT': invalid
        }

        // A standalone discard
        public static void Method(string arg)
        {
            _ = arg ?? throw new ArgumentNullException(paramName: nameof(arg), message: "arg can't be null");
            ExecuteAsyncMethods();
            ShowValue(19);
            // Do work with arg
        }

        private static async Task ExecuteAsyncMethods()
        {
            Console.WriteLine("About to launch a task...");
            _ = Task.Run(() =>
            {
                var iterations = 0;
                for (int ctr = 0; ctr < iterations; ctr++)
                    iterations++;
                Console.WriteLine("Completed looping operation...");
                throw new InvalidOperationException();
            });
            await Task.Delay(5000);
            Console.WriteLine("Existing after 5 second delay");
        }

        private static void ShowValue(int _)
        {
            byte[] arr = { 0, 0, 1, 2 };
            _ = BitConverter.ToInt32(arr, 0);
            Console.WriteLine(_);
        }
        // The example displays the following compiler error:
        //     error CS0029: Cannot implicitly convert type 'bool' to 'int'

        public void DoSomething(int _)
        {
            //var _ = GetValue(); // Error: cannot declare local _ when one is already in scope
        }
        // The example displays the following compiler error:
        // error CS0136:
        //        A local or parameter named '_' cannot be declared in this scope
        //        because that name is used in an enclosing local scope
        //        to define a local or parameter
    }
}

namespace Discards
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Person(string fname, string mname, string lname,
                      string cityName, string stateName)
        {
            FirstName = fname;
            MiddleName = mname;
            LastName = lname;
            City = cityName;
            State = stateName;
        }

        // Return the first and last name
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname,
                                out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }

    }
}