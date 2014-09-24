namespace P02EnterNumbers
{
    using System;

    public class EnterNumbers
    {
        public static void Main()
        {
            const int Start = 1;
            const int End = 100;
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isInvalid = false;
                do
                {
                    try
                    {
                        numbers[i] = ReadNumber(Start, End);
                        if (i > 0)
                        {
                            if (numbers[i] <= numbers[i - 1])
                            {
                                throw new ArithmeticException();
                            }

                            isInvalid = false;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The number must to be in range [" + Start + ".." + End + "]");
                        isInvalid = true;
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("The number must be greater than " + numbers[i - 1]);
                        isInvalid = true;
                    }
                } while (isInvalid);
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(" < ", numbers));
        }

        public static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new FormatException();
            }

            return number;
        }
    }
}
