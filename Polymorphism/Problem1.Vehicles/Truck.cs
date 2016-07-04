namespace Problem1.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuel, double consumptionPerKm)
            : base(fuel, consumptionPerKm)
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