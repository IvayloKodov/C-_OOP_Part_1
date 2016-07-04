using System;
using System.Collections.Generic;

public class Student
{
    public string name;

    public Student(string name)
    {
        this.name = name;
        StudentGroup studentGroup=new StudentGroup(name);
    }
}

public class StudentGroup
{
    static HashSet<String> allStudents;
    public static int uniqueCounter;

    public StudentGroup(string name)
    {
        if (!allStudents.Contains(name))
        {
            ++uniqueCounter;
            allStudents.Add(name);
        }
    }

    static StudentGroup()
    {
        allStudents=new HashSet<string>();
    }
}

public class UniqueStudentName
{
    public static void Main()
    {
        string input = Console.ReadLine();
        while (input!="End")
        {
            Student student = new Student(input);
            input = Console.ReadLine();
        }
        Console.WriteLine(StudentGroup.uniqueCounter);
    }
}