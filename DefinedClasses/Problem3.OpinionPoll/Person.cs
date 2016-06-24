using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.OpinionPull
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
        {
            this.age = age;
            this.name = "No name";
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}