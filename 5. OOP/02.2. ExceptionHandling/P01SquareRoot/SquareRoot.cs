namespace P01SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            Console.Write("Enter number: ");

            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArithmeticException();
                }

                double result = Math.Sqrt(num);
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
