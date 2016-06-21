namespace Problem4.CompanyRoster
{
    public class Employee
    {
        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;

        public Employee()
        {
            this.email = "n/a";
            this.age = -1;
        }
        public Employee(string name, decimal salary, string position, string department) 
            : this()
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }
    }
}