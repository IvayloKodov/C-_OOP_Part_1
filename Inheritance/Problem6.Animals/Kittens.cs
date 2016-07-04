using System;
namespace Problem6.Animals
{
    public class Kittens : Cat
    {
        public Kittens(string name, int age, string typeOfAnimal) 
            : base(name, age, "Female", typeOfAnimal)
        {
        }

        public override string Gender
        {
            set
            {
                if (value != "Female")
                {
                    throw new ArgumentException();
                }
                base.Gender = value;
            }
        }

        public override string ProduceSound()
        {
            return "Miau";
        }
    }
}