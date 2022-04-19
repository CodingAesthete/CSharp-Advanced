using System;
using System.Collections.Generic;

namespace _01.SpecialCars
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> listTiresYears = new List<List<int>>();
            List<List<double>> listTiresPressures = new List<List<double>>();
            List<int> listHorsePower = new List<int>();
            List<double> listCubciCapacity = new List<double>();
            Tires tires = new Tires();
            Engine engine = new Engine();
            List<Car> listCars = new List<Car>();
            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] splitted = input.Split();
                List<int> listYears = tires.GetTiresYears(splitted);
                List<double> listPressures = tires.GetTiresPressures(splitted);
                listTiresYears.Add(listYears);
                listTiresPressures.Add(listPressures);
            }
            string secondInput;
            while ((secondInput = Console.ReadLine()) != "Engines done")
            {
                string[] splitted = secondInput.Split();
                listHorsePower.Add(engine.GetHorsePower(splitted));
                listCubciCapacity.Add(engine.GetCubicCapacity(splitted));
            }
            string thirdInput;
            while ((thirdInput = Console.ReadLine()) != "Show special")
            {
                string[] splitted = thirdInput.Split();
                string make = splitted[0];
                string model = splitted[1];
                int year = int.Parse(splitted[2]);
                double fuelQuantity = double.Parse(splitted[3]);
                double fuelConsumption = double.Parse(splitted[4]);
                int engineIndex = int.Parse(splitted[5]);
                int tiresIndex = int.Parse(splitted[6]);
                int horsePower = listHorsePower[engineIndex];
                double pressure = tires.GetSumPressures(listTiresPressures, tiresIndex);
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineIndex, tiresIndex, horsePower, pressure);
                listCars.Add(car);
            }
            foreach (var car in listCars)
            {
                if (car.Year >= 2017 && car.HorsePower > 330 && car.Pressure > 9 && car.Pressure < 10)
                {
                    double fuelQuantity = car.Drive20Kilometers(car.FuelQuantity, car.FuelConsumption);
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {fuelQuantity}");
                }
            }
        }
    }

