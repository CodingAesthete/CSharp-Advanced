using System;
using System.Collections.Generic;
using System.Text;

namespace _01.SpecialCars
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public int EngineIndex { get; set; }
        public int TiresIndex { get; set; }
        public int HorsePower { get; set; }
        public double Pressure { get; set; }
        public Car(string make, string model, int year, double fuelQantity, double fuelConsumption, int engineIndex, int tiresIndex, int horsePower, double pressure)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQantity;
            FuelConsumption = fuelConsumption;
            EngineIndex = engineIndex;
            TiresIndex = tiresIndex;
            HorsePower = horsePower;
            Pressure = pressure;
        }
        public double Drive20Kilometers(double fuelQuantity, double fuelConsumption)
        {
            fuelQuantity -= (fuelConsumption / 100) * 20;
            return fuelQuantity;
        }
    }
}
