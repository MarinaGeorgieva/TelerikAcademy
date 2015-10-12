namespace _02_StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Working hours cannot be negative");
                }

                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return string.Format("{0} \nWeek salary: {1} \nWorking hours per day: {2}", 
                base.ToString(), this.WeekSalary, this.WorkHoursPerDay);
        }

    }
}
