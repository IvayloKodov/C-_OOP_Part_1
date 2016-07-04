using System;

namespace Problem2.VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuel;
        private double tankCapacity;

        protected Vehicle(double fuel, double consumptionPerKm,double tankCapacity)
        {
            this.Fuel = fuel;
            this.ConsumptionPerKm = consumptionPerKm;
            this.TankCapacity = tankCapacity;
        }

        public double Fuel
        {
            get { return this.fuel; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuel = value;
            }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
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