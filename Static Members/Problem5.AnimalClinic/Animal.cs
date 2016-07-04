namespace Problem5.AnimalClinic
{
    public class Animal
    {
        private string name;
        private string breed;

        public Animal(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override string ToString()
        {
            return $"{Name} {Breed}";
        }
    }
}
