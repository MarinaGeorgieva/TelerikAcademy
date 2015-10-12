namespace _02_BankAccounts
{
    public class Individual : Customer
    {
        public Individual(string name)
            : base(name)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
