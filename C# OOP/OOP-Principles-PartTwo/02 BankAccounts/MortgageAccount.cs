namespace _02_BankAccounts
{
    using System;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
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
                if (months <= 6)
                {
                    return 0m;
                }
                else
                {
                    months -= 6;
                    return base.CalculateInterestAmount(months);
                }
                
            }
            else if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return base.CalculateInterestAmount(months) * 0.5m;
                }
                else
                {
                    return base.CalculateInterestAmount(12) * 0.5m + base.CalculateInterestAmount(months - 12);
                }
            }
            else
            {
                return base.CalculateInterestAmount(months);
            }            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
