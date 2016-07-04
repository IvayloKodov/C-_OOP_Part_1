using System.Collections.Generic;

namespace Problem5.AnimalClinic
{
    public class AnimalClinic
    {
        public static int patientId;
        public static int healedAnimalsCount;
        public static int rehabilitedAnimalsCount;
        public static List<Animal> healedAnimals;
        public static List<Animal> rehabilitateddAnimals;

        public static void HealAnimal(Animal animal)
        {
            if (healedAnimals==null)
            {
                healedAnimals=new List<Animal>();
            }
            healedAnimals.Add(animal);
        }

        public static void RehabilitateAnimal(Animal animal)
        {
            if (rehabilitateddAnimals==null)
            {
                rehabilitateddAnimals=new List<Animal>();
            }
            rehabilitateddAnimals.Add(animal);
        }
    }
}