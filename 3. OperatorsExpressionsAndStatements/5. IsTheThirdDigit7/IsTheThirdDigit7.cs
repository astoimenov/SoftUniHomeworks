/* Write an expression that checks for given
 * integer if its third digit from right-to-left is 7.  */

using System;

class IsTheThirdDigit7
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        bool isItSeven = ((number / 100) % 10) == 7;
        Console.WriteLine(isItSeven);
    }
}