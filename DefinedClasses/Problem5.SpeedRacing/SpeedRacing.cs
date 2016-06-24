using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5.SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            //Read the cars
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                decimal fuelAmount = decimal.Parse(carInfo[1]);
                decimal fuelCostFor1km = decimal.Parse(carInfo[2]);
                Car newCar = new Car(model, fuelAmount, fuelCostFor1km);
                cars.Add(model, newCar);
            }
            //Read other commands
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] driveInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = driveInfo[1];
                decimal amountOfKm = decimal.Parse(driveInfo[2]);

                var updatedCar = cars.Where(c => c.Value.model == carModel)
                    .Select(c => Car.PossibiltyForMove(c.Value, amountOfKm)).ToList();
                cars[carModel] = updatedCar[0];
                input = Console.ReadLine();
            }
            //Print the updated results 
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:F2} {car.traveledDistance}");
            }
        }
    }
}