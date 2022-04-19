using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                Engine engine = new Engine();
                Cargo cargo = new Cargo();
                var tires = new List<Tire>();
                string[] splitted = Console.ReadLine().Split(" ", 6);
                string model = splitted[0];
                engine.Speed = int.Parse(splitted[1]);
                engine.Power = int.Parse(splitted[2]);
                cargo.Weight = int.Parse(splitted[3]);
                cargo.Type = splitted[4];
                var split = splitted[5].Split().ToArray();
                for (int j = 0; j < split.Length; j += 2) //7
                {
                    Tire tire = new Tire();
                    tire.Pressure = double.Parse(split[j]);
                    tire.Age = int.Parse(split[j + 1]);
                    tires.Add(tire);
                }
                Car car = new Car(model, engine, cargo, tires.ToArray());
                cars.Add(car);
            }
            string type = Console.ReadLine();
            if (type == "fragile")
            {
                DisplayFragile(cars);
            }
            else if (type == "flamable")
            {
                DisplayFlamable(cars);
            }
        }
        static void DisplayFragile(List<Car> cars)
        {
            foreach (var car in cars)
            {
                string model = "";
                foreach (var tyre in car.Tires)
                {
                    if (tyre.Pressure < 1 && car.Model != model)
                    {
                        model = car.Model;
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
        static void DisplayFlamable(List<Car> cars)
        {
            foreach (var car in cars)
            {
                if (car.Engine.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
