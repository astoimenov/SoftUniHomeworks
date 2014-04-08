/* Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns */

using System;

public class MatrixOfPalindromes
{
    public static void Main()
    {
        Console.Write("Input (r c): ");
        string input = Console.ReadLine();

        string[] rowsAndCols = input.Split(' ');

        int r = int.Parse(rowsAndCols[0]);
        int c = int.Parse(rowsAndCols[1]);
        const int a = 97;

        for (int i = a; i < r + a; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("{0}{1}{2} ", Convert.ToChar(i), Convert.ToChar(i + j), Convert.ToChar(i));
            }
            
            Console.WriteLine();
        }
    }
}