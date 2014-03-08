using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Write("First name: ");
        string fName = Console.ReadLine();
        Console.Write("Last name: ");
        string lName = Console.ReadLine();
        Console.WriteLine("Hello, " + fName + " " + lName + "!");
    }
}