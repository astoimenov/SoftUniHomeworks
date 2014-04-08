/* Define a method Fib(n) that calculates the nth Fibonacci number. */

using System;

public static class FibonacciNumbers
{
    public static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Fib(n);

        Console.WriteLine(result);
    }

    private static int Fib(int n)
    {
        int a = 0;
        int b = 1;
        for (int i = 0; i < n + 1; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a;
    }
}
