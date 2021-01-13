using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject.CarEquipmentFactories
{
    public interface ICarEquipmentFactory
    {
        public IEngine CreateEngine();

        public IWheel CreateWheel();

        public ISuspensions CreateSuspensions();
    }
}