/* Write a program that enters 3 real numbers and
 * prints them sorted in descending order. Use nested
 * if statements. Don’t use arrays and the built-in sorting functionality.  */

using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double firstNum;
        double secondNum;
        double thirdNum;

        if (a > b && a > c)
        {
            firstNum = a;
            if (b > c)
            {
                secondNum = b;
                thirdNum = c;
            }
            else
            {
                secondNum = c;
                thirdNum = b;
            }
        }
        else if (b > a && b > c)
        {
            firstNum = b;
            if (a > c)
            {
                secondNum = a;
                thirdNum = c;
            }
            else
            {
                secondNum = c;
                thirdNum = a;
            }
        }
        else
        {
            firstNum = c;
            if (a > b)
            {
                secondNum = a;
                thirdNum = b;
            }
            else
            {
                secondNum = b;
                thirdNum = a;
            }
        }
        Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
    }
}