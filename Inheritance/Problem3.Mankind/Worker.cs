using System;
using System.Text;

namespace Problem3.Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string secondName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        private double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        private double PayPerHour()
        {
            var payPerDay = this.WeekSalary / 5;
            var payPerHour = (double)payPerDay / this.WorkHoursPerDay;
            return payPerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.SecondName)
                .Append(Environment.NewLine)
                .Append("Week Salary: ").Append($"{this.WeekSalary:F2}")
                .Append(Environment.NewLine)
                .Append("Hours per day: ").Append($"{this.WorkHoursPerDay:F2}")
                .Append(Environment.NewLine)
                .Append("Salary per hour: ").Append($"{this.PayPerHour():F2}");
            return sb.ToString();
        }
    }
}