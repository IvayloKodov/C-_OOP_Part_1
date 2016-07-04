using System;
using System.Collections.Generic;

namespace Problem6.Animals
{
    public class Animals
    {
        public static void Main()
        {
            var allAnimals = new List<Animal>();

            string animal = Console.ReadLine();
            try
            {
                while (animal != "Beast!")
                {
                    string[] animalInfo = Console.ReadLine()
                        .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    switch (animal.ToLower())
                    {
                        case "dog":
                            Animal dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2], animal);
                            allAnimals.Add(dog);
                            break;
                        case "cat":
                            Animal cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2], animal);
                            allAnimals.Add(cat);
                            break;
                        case "frog":
                            Animal frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2], animal);
                            allAnimals.Add(frog);
                            break;
                        case "kitten":
                            Animal kitten = new Kittens(animalInfo[0], int.Parse(animalInfo[1]), animal);
                            allAnimals.Add(kitten);
                            break;
                        case "tomcat":
                            Animal tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]), animal);
                            allAnimals.Add(tomcat);
                            break;
                        case "animal":
                            Console.WriteLine("Not implemented!");
                            break;
                    }
                    animal = Console.ReadLine();
                }
                foreach (var currentAnimal in allAnimals)
                {
                    Console.WriteLine(currentAnimal);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}