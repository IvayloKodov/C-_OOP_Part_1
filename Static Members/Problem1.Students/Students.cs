using System;

public class Student
{
    public static int studentsCounter;
    public string name;

    public Student(string name)
    {
        this.name = name;
        Student.studentsCounter++;
    }
}

public class Students
{
    public static void Main()
    {
        string studentName = Console.ReadLine();
        while (studentName != "End")
        {
            Student student = new Student(studentName);
            studentName = Console.ReadLine();
        }
        Console.WriteLine(Student.studentsCounter);
    }
}