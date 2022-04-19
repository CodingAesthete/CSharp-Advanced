using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Engine
    {
        private string displacement = "n/a";
        private string efficiency = "n/a";
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }
    }
}

