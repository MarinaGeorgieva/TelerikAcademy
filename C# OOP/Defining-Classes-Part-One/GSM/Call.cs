namespace GSM
{
    using System;

    public class Call
    {
        private DateTime date;
        private string toPhoneNumber;
        private int duration; 

        public Call(DateTime date, string toPhoneNumber, int duration)
        {
            this.Date = date;
            this.ToPhoneNumber = toPhoneNumber;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
       
        public string ToPhoneNumber
        {
            get
            {
                return this.toPhoneNumber;
            }
            set
            {
                if (value == null || value == String.Empty)
                {
                    throw new ArgumentException("Dialed phone number must be entered");
                }

                this.toPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (duration < 0)
                {
                    throw new ArgumentException("Duration must be bigger than 0");
                }

                this.duration = value;
            }
        }       

        public override string ToString()
        {
            return String.Format("Date and time: {0:dd/MM/yyyy H:mm:ss} \nDialed phone number: {1} \nDuration (seconds): {2}\n",
                this.Date, this.ToPhoneNumber, this.Duration);
        }
    }
}
