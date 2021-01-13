using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject.CarEquipmentFactories
{
    public class StandartCarEquipmentFactory : ICarEquipmentFactory
    {
        public IEngine CreateEngine()
        {
            return new StandartFuelEngine();
        }

        public IWheel CreateWheel()
        {
            return new StandartWheel();
        }

        public ISuspensions CreateSuspensions()
        {
            return new StandartSuspension();
        }
    }
}