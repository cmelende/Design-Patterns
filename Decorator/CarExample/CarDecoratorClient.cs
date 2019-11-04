using System;
using Decorator.CarExample.Component;
using Decorator.CarExample.ConcreteComponent;
using Decorator.CarExample.ConcreteDecorator;
using Decorator.CarExample.Decorator;
using DesignPatternBase;

namespace Decorator.CarExample
{
    public class DecoratorClient : IDesignPatternClient
    {
        public string Name => "Decorator Example";
        public void Main()
        {
            //Create EconomyCar instance.   
            ICar objCar = new EconomyCar();

            //Wrp EconomyCar instance with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            Console.Write("Car Details: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();
        }
    }
}
