/* Write a program that prints an isosceles triangle
 * of 9 copyright symbols ©, something like this:
 *    ©
 *   © ©
 *  ©   ©
 * © © © ©
 * Note that the © symbol may be displayed incorrectly 
 * at the console so you may need to change the console
 * character encoding to UTF-8 and the console font. */

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copyright = '©';
        Console.WriteLine("   {0}", copyright);
        Console.WriteLine("  {0} {0}", copyright);
        Console.WriteLine(" {0}   {0}", copyright);
        Console.WriteLine("{0} {0} {0} {0}", copyright);
    }
}