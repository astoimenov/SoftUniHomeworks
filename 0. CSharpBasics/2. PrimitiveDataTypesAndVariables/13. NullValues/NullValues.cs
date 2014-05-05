/* Create a program that assigns null values to an 
 * integer and to a double variable. Try to print these
 * variables at the console. Try to add some number
 * or the null literal to these variables and print the result. */

using System;

class NullValues
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;
        Console.WriteLine("Integer null: {0}", intNull);
        Console.WriteLine("Double null: {0}", doubleNull);
        intNull++;
        doubleNull = doubleNull + 2;
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
    }
}