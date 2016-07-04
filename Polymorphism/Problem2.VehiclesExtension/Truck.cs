namespace Problem2.VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double consumptionPerKm, double tankCapacity)
            : base(fuel, consumptionPerKm,tankCapacity)
        {
        }
        public override double ConsumptionPerKm
        {
            get { return base.ConsumptionPerKm; }
            set
            {
                base.ConsumptionPerKm = value + 1.6;
            }
        }

        public override void Refuel(double litres)
        {
            base.Fuel += litres * 0.95;
        }
    }
}