using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6.RawData
{
    public class RawData
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tires[] tires = new Tires[4];
                tires[0] = new Tires(tire1Pressure, tire1Age);
                tires[1] = new Tires(tire2Pressure, tire2Age);
                tires[2] = new Tires(tire3Pressure, tire3Age);
                tires[3] = new Tires(tire4Pressure, tire4Age);

                Car car = new Car(carModel, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            var result = cars;
            if (command == "fragile")
            {//print all cars whose Cargo Type is “fragile” with a tire whose pressure is  < 1
                result = cars.Where(c => c.cargo.cargoType == "fragile" && c.tires.Any(t => t.tirePressure < 1)).ToList();
            }
            else
            {//print all cars whose Cargo Type is “flamable” and have Engine Power > 250
                result = cars.Where(c => c.cargo.cargoType == "flamable" && c.engine.enginePower > 250).ToList();
            }
            result.ForEach(c => Console.WriteLine($"{c.model}"));
        }
    }
}