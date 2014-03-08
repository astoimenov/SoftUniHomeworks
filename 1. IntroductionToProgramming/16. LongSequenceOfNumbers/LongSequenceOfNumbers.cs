using System;

class LongSequenceOfNumbers
{
    static void Main()
    {
        int num = 2;
        for (int i = 0; i < 999; i++)
        {
            if (num % 2 == 0)
            {
                Console.Write("{0}, ", num);
            }
            else
            {
                Console.Write("{0}, ", -num);
            }
            num++;
            if (i == 998)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0}", num);
                }
                else
                {
                    Console.WriteLine("{0}", -num);
                }
            }
        }
    }
}