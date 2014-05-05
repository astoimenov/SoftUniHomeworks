using System;

class PrintMyName
{
    static void Main()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }
}