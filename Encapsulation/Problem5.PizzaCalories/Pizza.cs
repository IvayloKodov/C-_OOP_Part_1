using System;
using System.Collections.Generic;

namespace Problem5.PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private int numberOfToppings;
        private double calories;

        public Pizza()
        {
            this.toppings = new List<Topping>();
            this.Dough = new Dough();
        }

        public Pizza(string name, int numberOfToppings) : this()
        {
            this.Name = name;
            this.NumberOfToppings = numberOfToppings;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public int NumberOfToppings
        {
            get { return this.numberOfToppings; }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }

                this.numberOfToppings = value;
            }
        }

        public Dough Dough { get; set; }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
            this.calories += topping.CalculateCalories();
        }

        public override string ToString()
        {
            return $"{this.name} - {this.calories + this.Dough.CalculateCalories():F2} Calories.";
        }
    }
}