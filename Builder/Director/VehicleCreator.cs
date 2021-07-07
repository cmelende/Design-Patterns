using BuilderPattern.Builder;
using BuilderPattern.Product;

namespace BuilderPattern.Director
{
    public class VehicleCreator
    {
        private readonly IVehicleBuilder _objBuilder;

        public VehicleCreator(IVehicleBuilder builder)
        {
            _objBuilder = builder;
        }

        public void CreateVehicle()
        {
            _objBuilder.SetModel();
            _objBuilder.SetEngine();
            _objBuilder.SetBody();
            _objBuilder.SetTransmission();
            _objBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return _objBuilder.GetVehicle();
        }
    }
}