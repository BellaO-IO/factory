using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns
{
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() { Color = "blue", IsDrivable = true };
                    
                case "motorcycle":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
