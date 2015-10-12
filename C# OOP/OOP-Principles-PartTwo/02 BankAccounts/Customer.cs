namespace _02_BankAccounts
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
