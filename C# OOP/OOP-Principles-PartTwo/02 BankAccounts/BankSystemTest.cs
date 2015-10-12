// Problem 2. Bank accounts

// A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
// Customers could be individuals or companies.
// All accounts have customer, balance and interest rate (monthly based).
// Deposit accounts are allowed to deposit and with draw money.
// Loan and mortgage accounts can only deposit money.
// All accounts can calculate their interest amount for a given period (in months). 
// In the common case its is calculated as follows: number_of_months * interest_rate.
// Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months 
// if are held by a company.
// Deposit accounts have no interest if their balance is positive and less than 1000.
// Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
// Your task is to write a program to model the bank system by classes and interfaces.
// You should identify the classes, interfaces, base classes and abstract actions and implement the 
// calculation of the interest functionality through overridden methods.

namespace _02_BankAccounts
{
    using System;

    public class BankSystemTest
    {
        static void Main(string[] args)
        {
            DepositAccount depositAccount1 = new DepositAccount(new Individual("Pesho"), 25000m, 12);
            DepositAccount depositAccount2 = new DepositAccount(new Company("Some Company"), 175000m, 25);

            LoanAccount loanAccount1 = new LoanAccount(new Individual("Gosho"), 7500.50m, 15);
            LoanAccount loanAccount2 = new LoanAccount(new Company("Some Other Company"), 51450.25m, 20);

            MortgageAccount mortgageAccount1 = new MortgageAccount(new Individual("Ivan"), 6300, 18);
            MortgageAccount mortgageAccount2 = new MortgageAccount(new Company("SKF"), 128000.50m, 10);

            depositAccount1.Withdraw(1500m);
            Console.WriteLine("{0:F2}", depositAccount1.Balance);

            loanAccount2.Deposit(2800.50m);
            Console.WriteLine("{0:F2}", loanAccount2.Balance);

            Console.WriteLine();
           
            Console.WriteLine("{0:F2}", depositAccount1.CalculateInterestAmount(12));
            Console.WriteLine("{0:F2}", depositAccount2.CalculateInterestAmount(12));
            Console.WriteLine("{0:F2}", loanAccount1.CalculateInterestAmount(3));
            Console.WriteLine("{0:F2}", loanAccount2.CalculateInterestAmount(8));
            Console.WriteLine("{0:F2}", mortgageAccount1.CalculateInterestAmount(12));
            Console.WriteLine("{0:F2}", mortgageAccount2.CalculateInterestAmount(18));

            Console.WriteLine();

            Bank bank = new Bank();
            bank.AddAccount(depositAccount1);
            bank.AddAccount(depositAccount2);
            bank.AddAccount(loanAccount1);
            bank.AddAccount(loanAccount2);
            bank.AddAccount(mortgageAccount1);
            bank.AddAccount(mortgageAccount2);

            Console.WriteLine(bank);
        }
    }
}
