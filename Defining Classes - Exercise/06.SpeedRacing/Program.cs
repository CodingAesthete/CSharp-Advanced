using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] splitted = Console.ReadLine().Split();
                string model = splitted[0];
                double fuelAmount = double.Parse(splitted[1]);
                double fuelConsumption = double.Parse(splitted[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                string carModel = command[1];
                double amountOfKm = double.Parse(command[2]);
                Car car = cars.Where(s => s.Model == carModel).ToList().First();
                car.CarForDriving(carModel, amountOfKm);
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Travelleddistance}");
            }
        }
    }
}