namespace GSM
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {        
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery gsmBattery;
        private Display gsmDisplay;

        private static GSM  iphone4S = new GSM("4S", "Apple", 720m, "Pesho", 
            new Battery("Li-Po", 200, 8, BatteryType.LiIon), new Display(3.5, 16000000));

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = 200m;
            this.Owner = "Gosho";
            this.GsmBattery = new Battery("Li-Ion");
            this.GsmDisplay = new Display(4.2, 500000);
            this.CallHistory = new List<Call>();           
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery gsmBattery, Display gsmDisplay)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.GsmBattery = gsmBattery;
            this.GsmDisplay = gsmDisplay;
            this.CallHistory = new List<Call>();
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Model is mandatory");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Manufacturer is mandatory");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative or zero");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Owner must be longer than 0");
                }

                this.owner = value;
            }
        }

        public Battery GsmBattery
        {
            get
            {
                return this.gsmBattery;
            }
            set
            {
                this.gsmBattery = value;
            }
        }

        public Display GsmDisplay
        {
            get
            {
                return this.gsmDisplay;
            }
            set
            {
                this.gsmDisplay = value;
            }
        }

        public List<Call> CallHistory { get; set; }

        public static GSM Iphone4S
        {
            get
            {
                return iphone4S;
            }
        }

        public void AddCall(Call someCall)
        {
            this.CallHistory.Add(someCall);
        }

        public void DeleteCall(Call someCall)
        {
            this.CallHistory.Remove(someCall);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateCallsPrice(decimal pricePerMinute)
        {
            decimal result = 0;

            foreach (Call call in this.CallHistory)
            {
                if (call.Duration % 60 == 0)
                {
                    result += call.Duration / 60 * pricePerMinute;
                }
                else
                {
                    result += (call.Duration / 60 + 1) * pricePerMinute;
                }                 
            }

            return result;
        }

        public void PrintCallHistory()
        {
            if (this.CallHistory.Count == 0)
            {
                Console.WriteLine("Call history is empty");
            }
            else
            {
                foreach (Call call in this.CallHistory)
                {
                    Console.WriteLine(call.ToString());
                }
            }    
        }

        public override string ToString()
        {           
            return String.Format("Model: {0}, Manufacturer: {1}, Price: {2:C}, Owner: {3}, Battery: {4}, Display: {5}",
                this.Model, this.Manufacturer, this.Price, this.Owner, this.GsmBattery, this.GsmDisplay);
        }
    }
}
