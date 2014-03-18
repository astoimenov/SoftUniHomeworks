/* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 * •	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
 * •	Prints on the console the number in reversed order: dcba (in our example 1102).
 * •	Puts the last digit in the first position: dabc (in our example 1201).
 * •	Exchanges the second and the third digits: acbd (in our example 2101).
 * The number has always exactly 4 digits and cannot start with 0. */

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        int digitD = number % 10;
        int digitC = (number / 10) % 10;
        int digitB = (number / 100) % 10;
        int digitA = (number / 1000) % 10;

        int sum = digitA + digitB + digitC + digitD;
        int dcba = digitA + digitB * 10 + digitC * 100 + digitD * 1000;
        int dabc = digitA * 100 + digitB * 10 + digitC + digitD * 1000;
        int acbd = digitA * 1000 + digitB * 10 + digitC * 100 + digitD;

        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("dcba: {0}", dcba);
        Console.WriteLine("dabc: {0}", dabc);
        Console.WriteLine("acbd: {0}", acbd);
    }
}