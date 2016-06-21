using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Problem4.CompanyRoster
{
    public class CompanyRoster
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            var allEnEmployees = new List<Employee>();
            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] empInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Employee newEmployee = new Employee(empInfo[0], decimal.Parse(empInfo[1]), empInfo[2], empInfo[3]);
                if (empInfo.Length > 5)
                {
                    if (empInfo[5].Contains("@"))
                    {
                        newEmployee.email = empInfo[5];
                    }
                    else
                    {
                        newEmployee.age = int.Parse(empInfo[5]);
                    }
                }

                if (empInfo.Length > 4)
                {
                    if (empInfo[4].Contains("@"))
                    {
                        newEmployee.email = empInfo[4];
                    }
                    else
                    {
                        newEmployee.age = int.Parse(empInfo[4]);
                    }
                }
                allEnEmployees.Add(newEmployee);
            }
            var sortedDepartment = allEnEmployees.GroupBy(emp => emp.department)
                                                  .OrderByDescending(d => d.Average(p => p.salary))
                                                  .FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {sortedDepartment.Key}");

            sortedDepartment.Select(p => new { p.name, p.salary, p.email, p.age })
                            .OrderByDescending(emp => emp.salary)
                            .ToList()
                            .ForEach(emp => Console.WriteLine($"{emp.name} {emp.salary:F2} {emp.email} {emp.age}"));
        }
    }
}