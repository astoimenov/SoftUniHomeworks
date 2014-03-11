/* Find online more information about ASCII (American Standard Code for Information Interchange)
 * and write a program to prints the entire ASCII table of characters at the console 
 * (characters from 0 to 255). Note that some characters have a special purpose and
 * will not be displayed as expected. You may skip them or display them differently.
 * You may need to use for-loops (learn in Internet how). */

using System;

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 255; i = i + 5)
        {
            Console.WriteLine("{0}    {1}    {2}    {3}    {4}",
                (char)i, (char)(i + 1), (char)(i + 2), (char)(i + 3), (char)(i + 4));
        }
    }
}