using System;

public class Car
{
    public double speed;
    public double fuel;
    public double fuelConsumption;
    public double travelledDidstance;
    public double travelledTime;

    public Car(double speed, double fuel, double fuelConsumption)
    {
        this.speed = speed;
        this.fuel = fuel;
        this.fuelConsumption = fuelConsumption;
    }

    public void Travel(double distance)
    {
        double possibleDistance = this.fuel / this.fuelConsumption * 100;
        if (distance <= possibleDistance)
        {
            this.fuel -= this.fuelConsumption * (distance / 100);
            this.travelledDidstance += distance;
            this.travelledTime += distance / this.speed * 60;
        }
        else
        {
            this.travelledDidstance += possibleDistance;
            this.fuel = 0;
            this.travelledTime += possibleDistance / this.speed * 60;
        }
    }

    public void Refuel(double refuelLiters)
    {
        this.fuel += refuelLiters;
    }
}

public class Launcher
{
    public static void Main()
    {
        string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double carSpeed = double.Parse(carInfo[0]);
        double carFuel = double.Parse(carInfo[1]);
        double carFuelConsumption = double.Parse(carInfo[2]);
        Car car = new Car(carSpeed, carFuel, carFuelConsumption);

        string[] command = Console.ReadLine().Split();
        while (command[0] != "END")
        {
            switch (command[0])
            {
                case "Travel":
                    double distance = double.Parse(command[1]);
                    car.Travel(distance);
                    break;
                case "Refuel":
                    double refuelLiters = double.Parse(command[1]);
                    car.Refuel(refuelLiters);
                    break;
                case "Distance":
                    Console.WriteLine($"Total distance: {car.travelledDidstance:F1} kilometers");
                    break;
                case "Time":
                    Console.WriteLine("Total time: {0} hours and {1} minutes",
                        car.travelledTime / 60, car.travelledTime % 60);
                    break;
                case "Fuel":
                    Console.WriteLine($"Fuel left: {car.fuel:F1} liters");
                    break;
            }
            command = Console.ReadLine().Split();
        }
    }
}