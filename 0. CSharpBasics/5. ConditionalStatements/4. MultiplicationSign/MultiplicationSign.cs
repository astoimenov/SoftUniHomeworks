/* Write a program that shows the sign (+, - or 0) 
 * of the product of three real numbers, without
 * calculating it. Use a sequence of if operators.  */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Result: ");

        if (a == 0 || b == 0|| c == 0)
        {
            Console.WriteLine(0);
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine('-');
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine('+');
        }
       
    }
}