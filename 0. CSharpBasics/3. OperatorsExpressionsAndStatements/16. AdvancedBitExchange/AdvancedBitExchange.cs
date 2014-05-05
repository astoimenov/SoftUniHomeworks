/* Write a program that exchanges bits {p, p+1, …, p+k-1}
 * with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned 
 * integer. The first and the second sequence of bits may not overlap.  */

using System;

class AdvancedBitExchange
{
    static void Main()
    {
        Console.Write("n: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());
        uint maskNumber = 0;
        if (Math.Max(p, q) + k > 31)
        {
            Console.WriteLine("out of range");
            return;
        }
        if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
            return;
        }
        for (int i = 0; i < k; i++)
        {
            maskNumber += (uint)Math.Pow(2, i);
        }
        uint mask = ((maskNumber << p) | (maskNumber << q));
        uint firstBitGroup = (n >> p) & maskNumber;
        uint secondBitGroup = (n >> q) & maskNumber;
        Console.WriteLine((n & (~mask)) | ((firstBitGroup << q) | (secondBitGroup << p)));
    }
}