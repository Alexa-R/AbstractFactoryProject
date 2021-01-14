using AbstractFactoryProject.CarEquipmentFactories;
using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject
{
    public class Car
    {
        public Car(ICarEquipmentFactory factory)
        {
            Engine = factory.CreateEngine();
            Suspensions = factory.CreateSuspensions();
            Wheel = factory.CreateWheel();
        }

        public IEngine Engine { get; set; }

        public ISuspensions Suspensions { get; set; }

        public IWheel Wheel { get; set; }
    }
}