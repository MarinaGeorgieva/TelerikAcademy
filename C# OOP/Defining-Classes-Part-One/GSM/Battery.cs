namespace GSM
{
    using System;

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;

        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = 20;
            this.HoursTalk = 10;
            this.Type = BatteryType.LiIon;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type) : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
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

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle must be bigger than 0");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk must be bigger than 0");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, Hours idle: {1}, Hours talk: {2}, Battery type: {3}", 
                this.Model, this.HoursIdle, this.HoursTalk, this.Type);
        }
    }
}
