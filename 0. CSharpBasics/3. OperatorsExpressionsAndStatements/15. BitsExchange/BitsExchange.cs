/* Write a program that exchanges bits 3, 4 and 5
 * with bits 24, 25 and 26 of given 32-bit unsigned integer.  */

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("n: ");
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 1;
        uint bit1;
        uint bit2;
        uint number1;
        byte k = 3;
        byte p = 24;
        for (byte i = 1; i <= 3; i++, k++, p++)
        {
            mask = mask << k;
            bit1 = (mask & n) >> k;
            mask = mask >> k;
            mask = mask << p;
            bit2 = (mask & n) >> p;
            mask >>= p;
            if (bit1 != bit2)
            {
                if (bit1 == 1)
                {
                    number1 = n | (mask << p);
                    n = number1 ^ (mask << k);
                }
                else
                {
                    number1 = n ^ (mask << p);
                    n = number1 | (mask << k);
                }
            }
        }
        Console.WriteLine(n);
    }
}