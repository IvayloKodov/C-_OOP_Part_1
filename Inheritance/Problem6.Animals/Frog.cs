using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender, string typeOfAnimal) 
            : base(name, age, gender, typeOfAnimal)
        {
        }

        public override string ProduceSound()
        {
            return "Frogggg";
        }
    }
}
