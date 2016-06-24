using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3.OpinionPull
{
    public class OpinionPoll
    {
        public static void Main()
        {
            List<Person> allPersons = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                Person newPerson = new Person(info[0], int.Parse(info[1]));
                allPersons.Add(newPerson);
            }
            allPersons.Where(p => p.age > 30)
                .OrderBy(p => p.name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
        }
    }
}