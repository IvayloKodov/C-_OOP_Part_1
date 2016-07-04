namespace Problem1.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuel, double consumptionPerKm)
            : base(fuel, consumptionPerKm)
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
            base.Fuel += litres;
        }
    }
}