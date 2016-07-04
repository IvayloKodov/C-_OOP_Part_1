using System;

namespace Problem5.AnimalClinic
{
    public class Launcher
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] animalInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string animalName = animalInfo[0];
                string animalBreed = animalInfo[1];
                string healOrRehab = animalInfo[2];
                Animal animal = new Animal(animalName, animalBreed);
                AnimalClinic.patientId++;

                if (healOrRehab == "heal")
                {
                    AnimalClinic.HealAnimal(animal);
                    AnimalClinic.healedAnimalsCount++;
                    Console.WriteLine($"Patient {AnimalClinic.patientId}: [{animal.Name} ({animal.Breed})] has been healed!");
                }
                else
                {
                    AnimalClinic.RehabilitateAnimal(animal);
                    AnimalClinic.rehabilitedAnimalsCount++;
                    Console.WriteLine($"Patient {AnimalClinic.patientId}: [{animal.Name} ({animal.Breed})] has been rehabilitated!");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitedAnimalsCount}");

            string command = Console.ReadLine();
            if (command == "heal")
            {
                foreach (var animal in AnimalClinic.healedAnimals)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
            else
            {
                foreach (var animal in AnimalClinic.rehabilitateddAnimals)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
        }
    }
}