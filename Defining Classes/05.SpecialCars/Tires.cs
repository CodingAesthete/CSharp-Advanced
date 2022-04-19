using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SpecialCars
{
    public class Tires
    {
        public int Year { get; set; }
        public double Pressure { get; set; }
        public List<int> GetTiresYears(string[] splitted)
        {
            List<int> tiresYears = new List<int>();
            for (int i = 0; i < splitted.Length; i += 2)
            {
                tiresYears.Add(int.Parse(splitted[i]));
            }
            return tiresYears;
        }
        public List<double> GetTiresPressures(string[] splitted)
        {
            List<double> tiresPressires = new List<double>();
            for (int i = 1; i < splitted.Length; i += 2)
            {
                tiresPressires.Add(double.Parse(splitted[i]));
            }
            return tiresPressires;
        }
        public double GetSumPressures(List<List<double>> listTiresPressure, int tiresIndex)
        {
            double sum = listTiresPressure[tiresIndex].Sum();
            return sum;
        }
    }
}