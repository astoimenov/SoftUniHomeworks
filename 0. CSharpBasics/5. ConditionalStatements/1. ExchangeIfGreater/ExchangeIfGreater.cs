/* Write an if-statement that takes two integer variables a and b
 * and exchanges their values if the first one is greater than
 * the second one. As a result print the values a and b, separated by a space.  */

using System;

class ExchangeIfGreater{
    static void Main()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}