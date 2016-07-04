namespace Problem6.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string typeOfAnimal) 
            : base(name, age, "Male", typeOfAnimal)
        {
        }
        public override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}