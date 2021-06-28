using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    class Car : IVehicle
    {

        public string Color { get; set; }
        public bool IsDrivable { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Sorry cant test I'm driving here in my {Color} car");
        }
    }
}
