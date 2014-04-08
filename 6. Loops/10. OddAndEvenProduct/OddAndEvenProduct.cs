/* You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is
 * equal to the product of the even elements. Elements are counted from 1 to n,
 * so the first element is odd, the second is even, etc.  */

using System;

class OddAndEvenProduct
{
    static void Main()
    {     
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string[] tokens = input.Split(' ');
        int oddProduct = 1,
            evenProduct = 1;
        for (int i = 0; i < tokens.Length; i += 2)
        {
            oddProduct *= int.Parse(tokens[i]);
        }
        for (int i = 1; i <= tokens.Length - 1; i += 2)
        {
            evenProduct *= int.Parse(tokens[i]);
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}