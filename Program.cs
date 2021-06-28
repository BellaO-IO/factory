using System;

namespace FactoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("we are doing cars again whatchu want? I make cars now. Car or Motorcyle? pick one dangit");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("we arr makin another cAAr pick one");
            userInput = Console.ReadLine();
            
        }
    }
}
