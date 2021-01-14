using System;
using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject.CarEquipmentFactories
{
    public class EconomyCarEquipmentFactory : ICarEquipmentFactory
    {
        public IEngine CreateEngine()
        {
            Console.WriteLine("The economy fuel engine is installed");
            return new EconomyFuelEngine();
        }

        public ISuspensions CreateSuspensions()
        {
            Console.WriteLine("The economy suspension is installed");
            return new EconomySuspension();
        }

        public IWheel CreateWheel()
        {
            Console.WriteLine("The economy wheels are screwed on");
            return new EconomyWheel();
        }
    }
}