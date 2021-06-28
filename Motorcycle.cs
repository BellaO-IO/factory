using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    class Motorcycle : IVehicle
    {
        public string Color { get; set; }
        public bool HasHandBreak { get; set; }
        public void Drive()
        {
            Console.WriteLine("Driving yer motorcycle");
        }
    }
}
