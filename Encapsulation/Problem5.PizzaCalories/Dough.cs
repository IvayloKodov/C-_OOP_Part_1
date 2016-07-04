using System;

namespace Problem5.PizzaCalories
{
    public class Dough
    {
        private const double whiteMod = 1.5;
        private const double wholegrainMod = 1.0;
        private const double crispyMod = 0.9;
        private const double chewyMod = 1.1;
        private const double homemadeMod = 1.0;
        private const int weightMin = 1;
        private const int weightMax = 200;

        private string flourType;
        private string technique;
        private double weight;

        public Dough()
        {
            
        }
        public Dough(string flourType, string technique, double weight)
        {
            this.FlourType = flourType;
            this.Technique = technique;
            this.Weight = weight;
        }

        private string FlourType
        {
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string Technique
        {
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" &&
                    value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.technique = value;
            }
        }

        private double Weight
        {
            set
            {
                if (value < weightMin || value > weightMax)
                {
                    throw new ArgumentException(
                        $"Dough weight should be in the range [{weightMin}..{weightMax}].");
                }
                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double result = 2 * this.weight;
            if (this.flourType.ToLower() == "white")
            {
                result *= whiteMod;
            }
            if (this.technique.ToLower() == "crispy")
            {
                result *= crispyMod;
            }
            else if (this.technique.ToLower() == "chewy")
            {
                result *= chewyMod;
            }
            return result;
        }
    }
}