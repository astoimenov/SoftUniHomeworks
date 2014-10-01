namespace P02CustomLINQExtensions
{
    using System;
    using System.Collections.Generic;

    public class TestExtensions
    {
        public static void Main()
        {
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Original collection: " + string.Join(", ", numbers));
            Console.WriteLine();

            IEnumerable<int> whereNot = numbers.WhereNot<int>(a => a == 3);
            Console.WriteLine("All numbers except 3: " + string.Join(", ", whereNot));
            Console.WriteLine();

            Console.WriteLine("The collection repeated 3 times: " + string.Join(", ", numbers.Repeat<int>(3)));
            Console.WriteLine();

            IEnumerable<string> stringItems = new List<string>() { "brilliance", "neuralgia", "annoyance", "nostalgia", "alcoholic" };
            Console.WriteLine("Items: " + string.Join(", ", stringItems));

            IEnumerable<string> suffixes = new List<string>() { "holic", "ance" };
            Console.WriteLine("Suffixes: -" + string.Join(", -", suffixes));

            Console.WriteLine(
                "Items ends with the suffixes: " + string.Join(", ", stringItems.WhereEndsWith(suffixes)));
            Console.WriteLine();
        }
    }
}
