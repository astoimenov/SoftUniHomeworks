namespace P01StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TestExtensions
    {
        public static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder("The quick brown fox jumps over the lazy dog");
            Console.WriteLine("Original text: " + stringBuilder);

            string subString = stringBuilder.Substring(10, 9);
            Console.WriteLine("Substring: " + subString);

            Console.WriteLine("Remove 'the' ( case-insensitive ): " + stringBuilder.RemoveText("the"));

            IEnumerable<double> numbers = new List<double>()
            {
                42,
                3.14,
                5.11,
                1.68
            };
            Console.WriteLine("Append all numbers: " + stringBuilder.AppendAll(numbers));
        }
    }
}
