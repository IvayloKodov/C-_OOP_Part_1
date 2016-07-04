using System;

namespace Problem3.Mankind
{
    public class Mankind
    {
        public static void Main()
        {
            string[] studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string studentFirstName = studentInfo[0];
            string studentSecondName = studentInfo[1];
            string facultyNumber = studentInfo[2];

            String[] workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string workerFirstName = workerInfo[0];
            string workerSecondName = workerInfo[1];
            decimal workerWeekSalary = decimal.Parse(workerInfo[2]);
            double workerHoursPerDay = double.Parse(workerInfo[3]);
            try
            {
                Student student = new Student(studentFirstName, studentSecondName, facultyNumber);
                Worker worker = new Worker(workerFirstName, workerSecondName, workerWeekSalary, workerHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}