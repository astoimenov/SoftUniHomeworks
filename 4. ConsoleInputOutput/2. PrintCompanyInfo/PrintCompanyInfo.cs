/* A company has name, address, phone number, fax number,
 * web site and manager. The manager has first name, last name,
 * age and a phone number. Write a program that reads the information 
 * about a company and its manager and prints it back on the console. */

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Company:");
        Console.Write("Name: ");
        string compName = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        long compPhone = long.Parse(Console.ReadLine());
        Console.Write("Fax number: ");
        long faxNumber = long.Parse(Console.ReadLine());
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        Console.WriteLine("Manager:");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        long manPhone = long.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Company");
        Console.WriteLine("Name: {0}, address: {1}", compName, address);
        Console.WriteLine("Phone: {0}, fax: {1}", compPhone, faxNumber);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine();
        Console.WriteLine("Manager");
        Console.WriteLine("{0} {1}, {2}", firstName, lastName, age);
        Console.WriteLine("Phone: {0}", manPhone);
    }
}