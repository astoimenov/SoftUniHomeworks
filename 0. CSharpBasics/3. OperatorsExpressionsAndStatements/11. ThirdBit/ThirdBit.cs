/* Using bitwise operators, write an expression for finding the value
 * of the bit #3 of a given unsigned integer. The bits are counted from
 * right to left, starting from bit #0. The result of the expression
 * should be either 1 or 0.  */

using System;

class ThirdBit
{
    static void Main()
    {
        Console.Write("Number: ");
        uint number = uint.Parse(Console.ReadLine());

        uint numRight = number >> 3;
        uint bit = numRight & 1;

        Console.WriteLine(bit);
    }
}