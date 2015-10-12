namespace _02_BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public List<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
            private set
            {
                this.accounts = value;
            }
        }

        public void AddAccount(Account account)
        {
            this.Accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.Accounts.Remove(account);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var account in this.Accounts)
            {
                result.Append(account.ToString() + "\n\n");
            }

            return result.ToString();
        }

    }
}
