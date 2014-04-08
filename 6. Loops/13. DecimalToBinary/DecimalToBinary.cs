/* Using loops write a program that converts an integer 
 * number to its binary representation. The input is entered
 * as long. The output should be a variable of type string.  */

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Decimal Number: ");
        long decNumber = long.Parse(Console.ReadLine());
        long remainder;
        string output = "";
        do
        {
            remainder = decNumber % 2;
            decNumber /= 2;
            output = remainder + output;
        } while (decNumber > 0);
        Console.WriteLine(output);
    }
}