using System;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    public string name;
    public int age;
    public string occupation;

    public Person(string name, int age, string occupation)
    {
        this.name = name;
        this.age = age;
        this.occupation = occupation;
    }

    public int CompareTo(Person other)
    {
        return this.age.CompareTo(other.age);
    }

    public override string ToString()
    {
        return $"{name} - age: {age}, occupation: {occupation}";
    }
}

public class PrintPeople
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var persons = new List<Person>();
        while (input != "END")
        {
            string[] personInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string personName = personInfo[0];
            int personAge = int.Parse(personInfo[1]);
            string personOccupation = personInfo[2];
            Person person = new Person(personName, personAge, personOccupation);
            persons.Add(person);
            input = Console.ReadLine();
        }
        persons.Sort();
        foreach (var person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}