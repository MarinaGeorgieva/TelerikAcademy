namespace _02_BankAccounts
{
    using System;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer cannot be null");
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Number of months cannot be negative");
            }

            return months * this.InterestRate;
        }

        public override string ToString()
        {
            return string.Format("Customer: {0} \nBalance: {1:F2} \nInterest rate: {2}", 
                this.Customer, this.Balance, this.InterestRate);
        }
    }
}
