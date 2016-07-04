using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.VehiclesExtension
{
    public class Bus:Vehicle
    {
        public Bus(double fuel, double consumptionPerKm, double tankCapacity) 
            : base(fuel, consumptionPerKm,tankCapacity)
        {
        }

        public override void Refuel(double litres)
        {
            if ((base.Fuel + litres) > base.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.Fuel += litres;
            }
        }

        public void TurnOnAirConditioner()
        {
            base.ConsumptionPerKm += 1.4;
        }
    }
}