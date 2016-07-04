namespace Problem6.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender, string typeOfAnimal) 
            : base(name, age, gender, typeOfAnimal)
        {
        }

        public override string ProduceSound()
        {
            return "MiauMiau";
        }
    }
}