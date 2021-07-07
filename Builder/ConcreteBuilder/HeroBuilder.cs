using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    public class HeroBuilder : IVehicleBuilder
    {
        private readonly Vehicle _objVehicle = new Vehicle();

        public void SetModel()
        {
            _objVehicle.Model = "Hero";
        }

        public void SetEngine()
        {
            _objVehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            _objVehicle.Transmission = "120 km/hr";
        }

        public void SetBody()
        {
            _objVehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            _objVehicle.Accessories.Add("Seat Cover");
            _objVehicle.Accessories.Add("Rear Mirror");
        }

        public Vehicle GetVehicle()
        {
            return _objVehicle;
        }
    }
}