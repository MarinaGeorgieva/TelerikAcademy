// Problem 11. Bank Account Data

// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
// 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string middleName = "Georgiev";
        string lastName = "Petrov";
        string holderName = firstName + " " + middleName + " " + lastName;
        double accountBalance = 350.75; 
        string bankName = "Raiffeisen Bank";
        string iban = "BG80BNBG96611020345678";
        ulong creditCard1 = 5423896512540954;
        ulong creditCard2 = 3498065370321743;
        ulong creditCard3 = 2561903462738157;

        Console.WriteLine("Holder name: " + holderName);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Account balance: " + accountBalance);
        Console.WriteLine("Credit card 1: " + creditCard1);
        Console.WriteLine("Credit card 2: " + creditCard2);
        Console.WriteLine("Credit card 3: " + creditCard3);

    }
}

