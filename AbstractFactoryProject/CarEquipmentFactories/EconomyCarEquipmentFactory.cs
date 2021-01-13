using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject.CarEquipmentFactories
{
    public class EconomyCarEquipmentFactory : ICarEquipmentFactory
    {
        public IEngine CreateEngine()
        {
            return new EconomyFuelEngine();
        }

        public IWheel CreateWheel()
        {
            return new EconomyWheel();
        }

        public ISuspensions CreateSuspensions()
        {
            return new EconomySuspension();
        }
    }
}