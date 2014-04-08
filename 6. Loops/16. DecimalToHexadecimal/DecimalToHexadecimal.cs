/* Using loops write a program that converts an integer number 
 * to its hexadecimal representation. The input is entered as long.
 * The output should be a variable of type string. */

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Decimal Number: ");
        long decNumber = long.Parse(Console.ReadLine());
        long remainder;
        string output = "";
        do
        {
            remainder = decNumber % 16;
            decNumber /= 16;
            switch (remainder)
            {
                case 10:
                    output = 'A' + output;
                    break;
                case 11:
                    output = 'B' + output;
                    break;
                case 12:
                    output = 'C' + output;
                    break;
                case 13:
                    output = 'D' + output;
                    break;
                case 14:
                    output = 'E' + output;
                    break;
                case 15:
                    output = 'F' + output;
                    break;
                    default:
                    output = remainder + output;
                    break;
            }
        } while (decNumber > 0);
        Console.WriteLine(output);
    }
}