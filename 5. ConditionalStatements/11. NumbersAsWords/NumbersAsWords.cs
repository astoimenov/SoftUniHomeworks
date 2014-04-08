/* Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.  */

using System;

class NumbersAsWords
{
    static void Main()
    {
        Console.Write("Number: ");
        int num = int.Parse(Console.ReadLine());

        int thirdDigit = num % 10;
        int secondDigit = (num / 10) % 10;
        int firstDigit = num / 100;

        if (num == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (num % 100 == 0)
        {
            switch (firstDigit)
            {
                case 1:
                    Console.WriteLine("One hundred");
                    break;
                case 2:
                    Console.WriteLine("Two hundred");
                    break;
                case 3:
                    Console.WriteLine("Three hundred");
                    break;
                case 4:
                    Console.WriteLine("Four hundred");
                    break;
                case 5:
                    Console.WriteLine("Five hundred");
                    break;
                case 6:
                    Console.WriteLine("Six hundred");
                    break;
                case 7:
                    Console.WriteLine("Seven hundred");
                    break;
                case 8:
                    Console.WriteLine("Eight hundred");
                    break;
                case 9:
                    Console.WriteLine("Nine hundred");
                    break;
            }
        }
        else
        {
            switch (firstDigit)
            {
                case 1:
                    Console.Write("One hundred and ");
                    break;
                case 2:
                    Console.Write("Two hundred and ");
                    break;
                case 3:
                    Console.Write("Three hundred and ");
                    break;
                case 4:
                    Console.Write("Four hundred and ");
                    break;
                case 5:
                    Console.Write("Five hundred and ");
                    break;
                case 6:
                    Console.Write("Six hundred and ");
                    break;
                case 7:
                    Console.Write("Seven hundred and ");
                    break;
                case 8:
                    Console.Write("Eight hundred and ");
                    break;
                case 9:
                    Console.Write("Nine hundred and ");
                    break;
            }
            switch (secondDigit)
            {
                case 1:
                    {
                        switch (thirdDigit)
                        {
                            case 1:
                                Console.WriteLine("Eleven");
                                break;
                            case 2:
                                Console.WriteLine("Twelve");
                                break;
                            case 3:
                                Console.WriteLine("Thirteen");
                                break;
                            case 4:
                                Console.WriteLine("Fourteen");
                                break;
                            case 5:
                                Console.WriteLine("Fifteen");
                                break;
                            case 6:
                                Console.WriteLine("Sixteen");
                                break;
                            case 7:
                                Console.WriteLine("Seventeen");
                                break;
                            case 8:
                                Console.WriteLine("Eighteen");
                                break;
                            case 9:
                                Console.WriteLine("Nineteen");
                                break;
                            default:
                                Console.WriteLine("Ten");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Fourty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty ");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
            }
            if (secondDigit != 1)
            {
                switch (thirdDigit)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                }
            }
        }
    }
}