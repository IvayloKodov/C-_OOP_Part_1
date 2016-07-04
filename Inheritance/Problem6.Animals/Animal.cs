using System;
namespace Problem6.Animals
{
    public abstract class Animal
    {
        private string typeOfAnimal;
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender, string typeOfAnimal)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.typeOfAnimal = typeOfAnimal;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }

        public virtual string Gender
        {
            get { return this.gender; }
            set
            {
                if (string.IsNullOrEmpty(value) || value != "Female" && value != "Male")
                {
                    throw new ArgumentNullException();
                }

                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.typeOfAnimal}\n{this.Name} {this.Age} {this.Gender}\n{ProduceSound()}";
        }
    }
}
