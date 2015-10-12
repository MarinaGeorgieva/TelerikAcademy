// Problem 10. Employee Data

/* A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console. */

using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "John";
        string lastName = "Doe";
        byte age = 35;
        char gender = 'm';
        ulong personalIdNumber = 8306112507;
        uint uniqueNumber = 27566572;

        Console.WriteLine("Employee's first name: " + firstName);
        Console.WriteLine("Employee's last name: " + lastName);
        Console.WriteLine("Employee's age: " + age);
        Console.WriteLine("Employee's gender: " + gender);
        Console.WriteLine("Employee's personal ID number: " + personalIdNumber);
        Console.WriteLine("Employee's unique number: " + uniqueNumber);
    }
}

