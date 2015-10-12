// Problem 2. Print Company Information

// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.WriteLine("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Enter company phone number: ");
        string companyPhone = Console.ReadLine();

        Console.WriteLine("Enter company fax number: ");
        string companyFax = Console.ReadLine();

        Console.WriteLine("Enter company web site: ");
        string companyWebSite = Console.ReadLine();

        Console.WriteLine("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Enter manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Enter manager age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter manager phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Аddress: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax: {0}", companyFax);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        
    }
}

