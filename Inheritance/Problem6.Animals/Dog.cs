namespace Problem6.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender, string typeOfAnimal) 
            : base(name, age, gender, typeOfAnimal)
        {
        }

        public override string ProduceSound()
        {
            return "BauBau";
        }
    }
}