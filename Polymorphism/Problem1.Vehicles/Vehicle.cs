using System;

namespace Problem1.Vehicles
{
    public abstract class Vehicle
    {
        private double fuel;

        protected Vehicle(double fuel, double consumptionPerKm)
        {
            this.Fuel = fuel;
            this.ConsumptionPerKm = consumptionPerKm;
        }

        public double Fuel
        {
            get { return this.fuel; }
            set
            {
                this.fuel = value;
            }
        }

        public virtual double ConsumptionPerKm { get; set; }

        public abstract void Refuel(double litres);

        public virtual void Drive(double distance)
        {
            double possibleDistance = this.Fuel / this.ConsumptionPerKm;
            if (distance <= possibleDistance)
            {
                this.Fuel -= distance * this.ConsumptionPerKm;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:F2}";
        }
    }
}