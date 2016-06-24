using System;
using System.Reflection;

namespace Problem1_DefineClassPerson
{
    public class DefineClassPerson
    {
        public static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person peshoPerson = new Person
            {
                name = "Pesho",
                age = 20
            };
            Person goshoPerson = new Person
            {
                name = "Gosho",
                age = 18
            };
            Person stamatPerson = new Person
            {
                name = "Stamat",
                age = 43
            };
        }
    }
}