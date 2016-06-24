using System;
using System.Collections.Generic;
using System.Linq;

public class Cat
{
    public string breed;
    public string name;
}
public class Siamese : Cat
{
    public decimal earSize;

    public Siamese(decimal earSize)
    {
        this.earSize = earSize;
    }

    public override string ToString()
    {
        return $"{this.breed} {this.name} {this.earSize}";
    }
}
public class Cymric : Cat
{
    public decimal furLenght;

    public Cymric(decimal furLenght)
    {
        this.furLenght = furLenght;
    }
    public override string ToString()
    {
        return $"{this.breed} {this.name} {this.furLenght}";
    }
}
public class StreetExtraordinaire : Cat
{
    public decimal decibelsOfMeow;

    public StreetExtraordinaire(decimal decibelsOfMeow)
    {
        this.decibelsOfMeow = decibelsOfMeow;
    }
    public override string ToString()
    {
        return $"{this.breed} {this.name} {this.decibelsOfMeow}";
    }
}

public class CatLady
{
    public static void Main()
    {
        var cats = new HashSet<Cat>();
        string input = Console.ReadLine();
        while (input != "End")
        {
            string[] catInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string catBreed = catInfo[0];
            string catName = catInfo[1];
            switch (catBreed)
            {
                case "StreetExtraordinaire":
                    Cat streetCat = new StreetExtraordinaire(decimal.Parse(catInfo[2]));
                    streetCat.name = catName;
                    streetCat.breed = catBreed;
                    cats.Add(streetCat);
                    break;
                case "Siamese":
                    Cat siameseCat = new Siamese(decimal.Parse(catInfo[2]));
                    siameseCat.name = catName;
                    siameseCat.breed = catBreed;
                    cats.Add(siameseCat);
                    break;
                case "Cymric":
                    Cat cymricCat = new Cymric(decimal.Parse(catInfo[2]));
                    cymricCat.name = catName;
                    cymricCat.breed = catBreed;
                    cats.Add(cymricCat);
                    break;
            }
            input = Console.ReadLine();
        }
        string requestedCat = Console.ReadLine();
        var resultCat = cats.First(c => c.name == requestedCat);
        Console.WriteLine(resultCat.ToString());
    }
}