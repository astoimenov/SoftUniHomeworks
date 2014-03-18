/* Write an expression that extracts from given integer n the value of given bit at index p.  */

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());


        int numRight = n >> p;
        int bit = numRight & 1;

        Console.WriteLine(bit);
    }
}