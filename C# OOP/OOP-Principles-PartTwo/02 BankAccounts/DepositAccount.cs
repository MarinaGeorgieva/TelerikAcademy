namespace _02_BankAccounts
{
    using System;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Amount cannot be bigger than balance of the account");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0m;
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
