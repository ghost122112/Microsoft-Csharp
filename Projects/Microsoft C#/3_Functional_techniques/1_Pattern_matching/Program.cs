

using SourceCode;

namespace PatternMatching
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");

            PatternMatchingSourceCode sourceCode = new PatternMatchingSourceCode("""
                =====================================
                      Pattern Matching in C#
                =====================================
                """);

            Continuation continuation = new Continuation("""
                =====================================
                  Continuation of Pattern Matching
                =====================================
                """);
            



            Console.WriteLine("\n\n\n\n\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

namespace SourceCode
{
    public class PatternMatchingSourceCode
    {
        private string _Message { get; set; }
        public PatternMatchingSourceCode(string message)
        {
            _Message = message;
            Console.WriteLine(message);

            // Null checks
            int? maybe = 12;

            if (maybe is int number)
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            else
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");

            string? Message = "This is not the null string";

            if (Message is not null)
                Console.WriteLine(Message);

        }
        // Type tests
        public static T MidPoint<T>(IEnumerable<T> sequence)
        {
            if (sequence is IList<T> list)
            {
                return list[list.Count / 2];
            }
            else if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
            }
            else
            {
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0) halfLength = 0;
                return sequence.Skip(halfLength).First();
            }
        }
    }

    public class Continuation : PatternMatchingSourceCode
    {
        public Continuation(string message) : base(message)
        {
            string WaterState(int tempInFahrenheit) =>
                tempInFahrenheit switch
                {
                    (> 32) and (< 212) => "liquid",
                    < 32 => "solid",
                    > 212 => "gas",
                    32 => "solid/liquid transition",
                    212 => "liquid / gas transition",
                };

            WaterState(100);

        }

    }
}