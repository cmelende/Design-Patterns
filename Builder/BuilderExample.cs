using System;
using Builder.Director;
using DesignPatternBase;

namespace Builder
{
    public class BuilderExample : IDesignPatternClient
    {
        public string Name => "Builder";
        public void Main()
        {
            var vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.ReadKey();
        }
    }
}