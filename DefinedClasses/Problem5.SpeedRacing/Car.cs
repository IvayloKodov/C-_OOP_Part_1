using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5.SpeedRacing
{
    public class Car
    {
        public string model;
        public decimal fuelAmount;
        public decimal fuelConsumption;
        public decimal traveledDistance;

        public Car()
        {
            this.traveledDistance = 0;
        }

        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
        }

        public static Car PossibiltyForMove(Car car, decimal kmToMove)
        {
            decimal possibleKmToMove = car.fuelAmount / car.fuelConsumption;
            if (kmToMove <= possibleKmToMove)
            {
                car.traveledDistance += kmToMove;
                car.fuelAmount -= kmToMove * car.fuelConsumption;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            return car;
        }
    }
}