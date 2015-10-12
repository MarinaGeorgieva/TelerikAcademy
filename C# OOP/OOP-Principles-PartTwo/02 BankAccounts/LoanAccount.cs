namespace _02_BankAccounts
{
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Number of months cannot be negative");
            }

            if (this.Customer is Individual)
            {
                months -= 3;
            }
            else if (this.Customer is Company)
            {
                months -= 2;
            }

            if (months < 0)
            {
                months = 0;
            }

            return base.CalculateInterestAmount(months);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
