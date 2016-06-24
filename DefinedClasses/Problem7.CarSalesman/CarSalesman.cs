using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7.CarSalesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);
                Engine engine = new Engine(engineModel, enginePower);
                if (engineInfo.Length > 2)
                {
                    int displacement = 0;
                    bool isDisplacement = Int32.TryParse(engineInfo[2], out displacement);
                    if (isDisplacement)
                    {
                        engine.displacement = displacement;
                    }
                    else
                    {
                        engine.efficiency = engineInfo[2];
                    }
                }
                if (engineInfo.Length > 3)
                {
                    engine.efficiency = engineInfo[3];
                }
                engines.Add(engine);
            }
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                string carEngine = carInfo[1];
                var getCarEngine = engines.First(e => e.model == carEngine);
                Car car = new Car(carModel, getCarEngine);

                if (carInfo.Length > 2)
                {
                    int weight = 0;
                    bool isWeight = Int32.TryParse(carInfo[2], out weight);
                    if (isWeight)
                    {
                        car.weight = weight;
                    }
                    else
                    {
                        car.color = carInfo[2];
                    }
                }
                if (carInfo.Length > 3)
                {
                    car.color = carInfo[3];
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.model}:");
                Console.WriteLine($"  {car.engine.model}:");
                Console.WriteLine($"    Power: {car.engine.power}");
                Console.WriteLine("    Displacement: {0}", car.engine.displacement == 0 ? "n/a" : car.engine.displacement.ToString());
                Console.WriteLine("    Efficiency: {0}", car.engine.efficiency == null ? "n/a" : car.engine.efficiency.ToString());
                Console.WriteLine("  Weight: {0}", car.weight == 0 ? "n/a" : car.weight.ToString());
                Console.WriteLine("  Color: {0}", car.color == null ? "n/a" : car.color);
            }
        }
    }
}