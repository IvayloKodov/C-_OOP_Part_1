using System;
using System.Collections.Generic;

public class Person
{
    public string name;
    public Company company;
    public Car car;
    public List<Pokemon> pokemons;
    public List<Parents> parents;
    public List<Children> children;

    public Person()
    {
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parents>();
        this.children = new List<Children>();
    }
    public Person(Company company) : this()
    {
        this.company = company;
    }
    public Person(Car car) : this()
    {
        this.car = car;
    }
}

public class Company
{
    public string companyName;
    public string department;
    public double salary;

    public Company(string companyName, string department, double salary)
    {
        this.companyName = companyName;
        this.department = department;
        this.salary = salary;
    }
}

public class Pokemon
{
    public string pokemonName;
    public string pokemonType;

    public Pokemon(string pokemonName, string pokemonType)
    {
        this.pokemonName = pokemonName;
        this.pokemonType = pokemonType;
    }
}

public class Parents
{
    public string parentName;
    public string parentBirthday;

    public Parents(string parentName, string parentBirthday)
    {
        this.parentName = parentName;
        this.parentBirthday = parentBirthday;
    }
}

public class Children
{
    public string childrenName;
    public string childrenBirthday;

    public Children(string childrenName, string childrenBirthday)
    {
        this.childrenName = childrenName;
        this.childrenBirthday = childrenBirthday;
    }
}

public class Car
{
    public string carModel;
    public int carSpeed;

    public Car(string carModel, int carSpeed)
    {
        this.carModel = carModel;
        this.carSpeed = carSpeed;
    }
}

public class Google
{
    public static Dictionary<string, Person> people = new Dictionary<string, Person>();

    public static void Main()
    {
        string input = Console.ReadLine();
        while (input != "End")
        {
            string[] personInfo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string personName = personInfo[0];
            string dataType = personInfo[1];
            bool doesPersonExist = people.ContainsKey(personName);

            switch (dataType)
            {
                case "company":
                    Company currentCompany = new Company(personInfo[2], personInfo[3], double.Parse(personInfo[4]));
                    if (doesPersonExist)
                    {
                        people[personName].company = currentCompany;
                    }
                    else
                    {
                        people.Add(personName, new Person(currentCompany));
                    }
                    break;
                case "car":
                    Car currentCar = new Car(personInfo[2], int.Parse(personInfo[3]));
                    if (doesPersonExist)
                    {
                        people[personName].car = currentCar;
                    }
                    else
                    {
                        people.Add(personName, new Person(currentCar));
                    }
                    break;
                case "pokemon":
                    Pokemon currentPokemon = new Pokemon(personInfo[2], personInfo[3]);
                    if (!doesPersonExist)
                    {
                        people.Add(personName, new Person());
                    }
                    people[personName].pokemons.Add(currentPokemon);
                    break;
                case "parents":
                    Parents currentParent = new Parents(personInfo[2], personInfo[3]);
                    if (!doesPersonExist)
                    {
                        people.Add(personName, new Person());
                    }
                    people[personName].parents.Add(currentParent);
                    break;
                case "children":
                    Children currentChild = new Children(personInfo[2], personInfo[3]);
                    if (!doesPersonExist)
                    {
                        people.Add(personName, new Person());
                    }
                    people[personName].children.Add(currentChild);
                    break;
            }
            input = Console.ReadLine();
        }

        string wantedPerson = Console.ReadLine();
        Person currentPerson = people[wantedPerson];
        Console.WriteLine(wantedPerson);
        Console.WriteLine(currentPerson.company != null ? string.Format("Company:\n{0} {1} {2:F2}", currentPerson.company.companyName, currentPerson.company.department, currentPerson.company.salary) : "Company:");
        Console.WriteLine(currentPerson.car != null ? string.Format("Car:\n{0} {1}", currentPerson.car.carModel, currentPerson.car.carSpeed) : "Car:");
        Console.WriteLine("Pokemon:");
        currentPerson.pokemons.ForEach(pok => Console.WriteLine($"{pok.pokemonName} {pok.pokemonType}"));
        Console.WriteLine("Parents:");
        currentPerson.parents.ForEach(par => Console.WriteLine($"{par.parentName} {par.parentBirthday}"));
        Console.WriteLine("Children:");
        currentPerson.children.ForEach(child => Console.WriteLine($"{child.childrenName} {child.childrenBirthday}"));
    }
}