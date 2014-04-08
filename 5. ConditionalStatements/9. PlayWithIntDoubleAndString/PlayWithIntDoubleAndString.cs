/* Write a program that, depending on the user’s choice, 
 * inputs an int, double or string variable. If the 
 * variable is int or double, the program increases it by one. 
 * If the variable is a string, the program appends "*" 
 * at the end. Print the result at the console.  */

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("\t1 --> int");
        Console.WriteLine("\t2 --> double");
        Console.WriteLine("\t3 --> string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int intNumber = int.Parse(Console.ReadLine());
                intNumber++;
                Console.WriteLine(intNumber);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber++;
                Console.WriteLine(doubleNumber);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string input = Console.ReadLine();
                string result = input + '*';
                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("Wrong choice!");
                break;
        }
    }
}