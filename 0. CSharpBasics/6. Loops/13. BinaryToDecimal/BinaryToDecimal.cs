/* Using loops write a program that converts a binary integer
 * number to its decimal form. The input is entered as string.
 * The output should be a variable of type long. Do not use the built-in .NET functionality.  */

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        long decNumber = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[input.Length - i - 1] == '0')
            {
                continue;
            }

            decNumber += (long)Math.Pow(2, i);
        }

        Console.WriteLine(decNumber);
    }
}