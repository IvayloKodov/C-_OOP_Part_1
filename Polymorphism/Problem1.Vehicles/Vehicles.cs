using System;

namespace Problem1.Vehicles
{
    public class Vehicles
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine()
                                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double carFuel = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            Car car = new Car(carFuel, carConsumption);

            string[] truckInfo = Console.ReadLine()
                                    .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double truckFuel = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);
            Truck truck = new Truck(truckFuel, truckConsumption);

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                string vehicle = input[1].ToLower();
                double distanceOrLitres = double.Parse(input[2]);

                switch (input[0].ToLower())
                {
                    case "drive":
                        if (vehicle == "car")
                        {
                            car.Drive(distanceOrLitres);
                        }
                        else if (vehicle == "truck")
                        {
                            truck.Drive(distanceOrLitres);
                        }
                        break;
                    case "refuel":
                        if (vehicle == "car")
                        {
                            car.Refuel(distanceOrLitres);
                        }
                        else if (vehicle == "truck")
                        {
                            truck.Refuel(distanceOrLitres);
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}