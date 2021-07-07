using System;
using Decorator;
using Decorator.MarineArenaExample.Component;
using Decorator.MarineArenaExample.ConcreteComponent;
using DecoratorPattern.MarineArenaExample.ConcreteComponent;
using DecoratorPattern.MarineArenaExample.ConcreteDecorator;
using DecoratorPattern.MarineArenaExample.Decorator;
using DesignPatternBase;

namespace DecoratorPattern.MarineArenaExample
{
    public class DecoratorArenaClient : IDesignPatternClient
    {
        public string Name => "Decorator Arena Example";

        public void Main()
        {
            MarineDecorator marineWithEquipment = PromptBuildMarine();
            marineWithEquipment.PrintStats();
        }

        private MarineDecorator PromptBuildMarine()
        {
            int marineType = PromptMarineType();
            IMarine marine = MarineFactoryMethod(marineType);
            MarineDecorator marineWithEquipment = PromptChooseEquipment(marine);

            return marineWithEquipment;
        }

        private MarineDecorator PromptChooseEquipment(IMarine marine)
        {
            MarineDecorator marineWithEquipment;
            var doneEquipping = false;
            do
            {
                int decoratorChoice = PromptMarineDecorator();
                marineWithEquipment = ApplyDecorator(decoratorChoice, marine);

                Console.WriteLine("Done choosing equipment?");
                string isDoneInput = Console.ReadLine()?.ToLower();

                if (isDoneInput == "y" || isDoneInput == "yes") doneEquipping = true;
            } while (!doneEquipping);

            return marineWithEquipment;
        }

        public int PromptMarineType()
        {
            Console.WriteLine("Enter which type of marine you want");
            Console.WriteLine("Grunt: 1");
            Console.WriteLine("Sargent: 2");
            Console.WriteLine("Captain: 3");
            Console.WriteLine("General: 4");
            string input = Console.ReadLine();

            bool isValidInput = int.TryParse(input, out int validIndex);
            if (isValidInput) return validIndex;

            throw new Exception("Invalid entry, please select a number from the list");
        }

        public IMarine MarineFactoryMethod(int input)
        {
            switch (input)
            {
                case 1:
                    return new Grunt();
                case 2:
                    return new Sargent();
                case 3:
                    return new Captain();
                case 4:
                    return new General();
                default:
                    throw new Exception("Invalid Input");
            }
        }

        public int PromptMarineDecorator()
        {
            Console.WriteLine("Choose a loadout");
            Console.WriteLine("Basic Loadout: 1");
            Console.WriteLine("Basic Armor: 2");
            Console.WriteLine("Advanced Loadout: 3");
            Console.WriteLine("Advanced Armor: 4");
            Console.WriteLine("Elite Loadout: 5");
            Console.WriteLine("Elite Armor: 6");
            string input = Console.ReadLine();

            bool isValidInput = int.TryParse(input, out int validIndex);
            if (isValidInput) return validIndex;

            throw new Exception("Invalid entry, please select a number from the list");
        }

        public MarineDecorator ApplyDecorator(int input, IMarine marine)
        {
            switch (input)
            {
                case 1:
                    return new BasicLoadoutDecorator(marine);
                case 2:
                    return new BasicArmorDecorator(marine);
                case 3:
                    return new AdvancedLoadout(marine);
                case 4:
                    return new AdvancedArmor(marine);
                case 5:
                    return new EliteLoadout(marine);
                case 6:
                    return new EliteArmor(marine);
                default:
                    throw new Exception("Invalid input");
            }
        }
    }
}