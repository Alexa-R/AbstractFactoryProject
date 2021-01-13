using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject.CarEquipmentFactories
{
    public class ExtraCarEquipmentFactory : ICarEquipmentFactory
    {
        public IEngine CreateEngine()
        {
            return new ExtraFuelEngine();
        }

        public IWheel CreateWheel()
        {
            return new ExtraWheel();
        }

        public ISuspensions CreateSuspensions()
        {
            return new ExtraSuspension();
        }
    }
}