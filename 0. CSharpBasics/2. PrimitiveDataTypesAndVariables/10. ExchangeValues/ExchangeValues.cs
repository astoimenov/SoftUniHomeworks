/* Declare two integer variables a and b and assign them
 * with 5 and 10 and after that exchange their values.
 * Print the variable values before and after the exchange. */

using System;

class ExchangeValues
{
    static void Main()
    {
        int tmp;
        int a = 5;
        int b = 10;
        Console.WriteLine("Before the exchange:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        tmp = a;
        a = b;
        b = tmp;
        Console.WriteLine("After the exchange:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}