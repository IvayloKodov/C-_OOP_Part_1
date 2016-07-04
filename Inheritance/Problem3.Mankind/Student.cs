using System;
using System.Text;

namespace Problem3.Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string secondName, string facultyNumber)
            : base(firstName, secondName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string FirstName
        {
            get { return base.FirstName; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
                }

                base.FirstName = value;
            }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]) && !char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
              .Append(Environment.NewLine)
              .Append("Last Name: ").Append(this.SecondName)
              .Append(Environment.NewLine)
              .Append("Faculty number: ").Append(this.FacultyNumber);
            return sb.ToString();
        }
    }
}