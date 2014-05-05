/* Write a Boolean expression that returns if the bit
 * at position p (counting from 0, starting from the right)
 * in given integer number n has value of 1.  */

using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());


        int numRight = n >> p;
        int bit = numRight & 1;
        bool isItOne = bit == 1;

        Console.WriteLine(isItOne);
    }
}