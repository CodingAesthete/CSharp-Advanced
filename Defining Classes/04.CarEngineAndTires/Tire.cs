using System;
using System.Collections.Generic;
using System.Text;

namespace _04.CarEngineAndTires
{
    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}

