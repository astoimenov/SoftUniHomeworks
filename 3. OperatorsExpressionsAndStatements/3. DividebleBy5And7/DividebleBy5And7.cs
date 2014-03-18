/* Write a Boolean expression that checks for given 
 * integer if it can be divided (without remainder) 
 * by 7 and 5 in the same time.  */

using System;

class DividebleBy5And7
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        bool isDivideble = (number % 5) == 0 && (number % 7) == 0;
        Console.WriteLine(isDivideble);
    }
}