using System;

class SequenceOfNumbers
{
    static void Main()
    {
        int num = 2;
        for (int i = 0; i < 9; i++)
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
            if (i == 8)
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