using System;
using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject.CarEquipmentFactories
{
    public class ExtraCarEquipmentFactory : ICarEquipmentFactory
    {
        public IEngine CreateEngine()
        {
            Console.WriteLine("The extra fuel engine is installed");
            return new ExtraFuelEngine();
        }

        public ISuspensions CreateSuspensions()
        {
            Console.WriteLine("The extra suspension is installed");
            return new ExtraSuspension();
        }

        public IWheel CreateWheel()
        {
            Console.WriteLine("The extra wheels are screwed on");
            return new ExtraWheel();
        }
    }
}