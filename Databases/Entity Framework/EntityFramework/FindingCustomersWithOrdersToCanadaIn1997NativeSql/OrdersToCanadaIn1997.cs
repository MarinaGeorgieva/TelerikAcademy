namespace FindingCustomersWithOrdersToCanadaIn1997NativeSql
{
    using System;

    public class OrdersToCanadaIn1997
    {
        public string Customer { get; set; }

        public string ShipCountry { get; set; }

        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            string result = "Customer: " + this.Customer +
                ", ShipCountry: " + this.ShipCountry +
                ", OrderDate: " + this.OrderDate.ToString();
            return result;
        }
    }
}
