using System;

namespace Problem5.PizzaCalories
{
    public class Topping
    {
        private const double meatMod = 1.2;
        private const double veggiesMod = 0.8;
        private const double cheeseMode = 1.1;
        private const double sauceMod = 0.9;
        private const double weightMin = 1;
        private const double weightMax = 50;
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string Type
        {
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            }
        }

        private double Weight
        {
            set
            {
                if (value < weightMin || value > weightMax)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [{weightMin}..{weightMax}].");
                }
                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double result = this.weight * 2;
            if (this.type.ToLower() == "meat")
            {
                result *= meatMod;
            }
            else if (this.type.ToLower() == "veggies")
            {
                result *= veggiesMod;
            }
            else if (this.type.ToLower() == "cheese")
            {
                result *= cheeseMode;
            }
            else
            {
                result *= sauceMod;
            }
            return result;
        }
    }
}