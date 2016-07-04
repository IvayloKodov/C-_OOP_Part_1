using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.VehiclesExtension
{
    public class Program
    {
        public static void Main()
        {
            //CAR
            string[] carInfo = Console.ReadLine()
                                   .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double carFuel = double.Parse(carInfo[1]);
            double carConsumption = double.Parse(carInfo[2]);
            double carTank = double.Parse(carInfo[3]);
            Car car = new Car(carFuel, carConsumption, carTank);

            //TRUCK
            string[] truckInfo = Console.ReadLine()
                                    .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double truckFuel = double.Parse(truckInfo[1]);
            double truckConsumption = double.Parse(truckInfo[2]);
            double truckTank = double.Parse(truckInfo[3]);
            Truck truck = new Truck(truckFuel, truckConsumption, truckTank);

            //BUS
            string[] busInfo = Console.ReadLine()
                                    .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            double busFuel = double.Parse(busInfo[1]);
            double busConsumption = double.Parse(busInfo[2]);
            double busTank = double.Parse(busInfo[3]);
            Bus bus = new Bus(busFuel, busConsumption, busTank);

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
                        else if (vehicle == "bus")
                        {
                            bus.TurnOnAirConditioner();
                            bus.Drive(distanceOrLitres);
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
                        else if (vehicle == "bus")
                        {
                            bus.Refuel(distanceOrLitres);
                        }
                        break;
                    case "driveempty":
                        bus.Drive(distanceOrLitres);
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
