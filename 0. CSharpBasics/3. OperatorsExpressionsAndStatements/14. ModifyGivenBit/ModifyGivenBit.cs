/* We are given an integer number n, a bit value v (v=0 or 1)
 * and a position p. Write a sequence of operators (a few lines of C# code)
 * that modifies n to hold the value v at the position p from the binary 
 * representation of n while preserving all other bits in n.  */

using System;

class ModifyGivenBit
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v: ");
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
        else if (v == 1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Incorrect value of v!");
        }
    }
}