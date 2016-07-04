using System;

namespace Problem2.VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuel, double consumptionPerKm, double tankCapacity)
            : base(fuel, consumptionPerKm,tankCapacity)
        {
        }

        public override double ConsumptionPerKm
        {
            get { return base.ConsumptionPerKm; }
            set
            {
                base.ConsumptionPerKm = value + 0.9;
            }
        }

        public override void Refuel(double litres)
        {
            if ((base.Fuel + litres)>base.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.Fuel += litres;
            }
        }
    }
}