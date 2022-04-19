using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.SoftUniParking
{
    public class Parking
    {
        public List<Car> cars;
        public int capacity;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }
        public int Count => cars.Count;
        public string AddCar(Car car)
        {
            foreach (Car caro in cars)
            {
                if (caro.RegistrationNumber == car.RegistrationNumber)
                {
                    return "Car with that registration number, already exists!";
                }
            }
            if (cars.Count + 1 > capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            if (!cars.Any(s => s.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Car car = cars.First(s => s.RegistrationNumber == registrationNumber);
                cars.Remove(car);
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            Car car = cars.First(s => s.RegistrationNumber == registrationNumber);
            return car;
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            this.cars = cars.Where(c => !RegistrationNumbers.Contains(c.RegistrationNumber)).ToList();
        }
    }
}