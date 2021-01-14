using System;
using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject.CarEquipmentFactories
{
    public class StandartCarEquipmentFactory : ICarEquipmentFactory
    {
        public IEngine CreateEngine()
        {
            Console.WriteLine("The standart fuel engine is installed");
            return new StandartFuelEngine();
        }

        public ISuspensions CreateSuspensions()
        {
            Console.WriteLine("The standart suspension is installed");
            return new StandartSuspension();
        }

        public IWheel CreateWheel()
        {
            Console.WriteLine("The standart wheels are screwed on");
            return new StandartWheel();
        }
    }
}