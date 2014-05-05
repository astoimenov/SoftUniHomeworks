/* Write a program that reads a number n and prints
 * on the console the first n members of the Fibonacci 
 * sequence (at a single line, separated by spaces)  */

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c;
        Console.Write("{0} {1} ", a, b);
        for (int i = 0; i < n - 2; i++)
        {
            c = a + b;
            Console.Write("{0} ", c);
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}