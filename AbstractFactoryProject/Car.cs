using AbstractFactoryProject.CarEquipmentFactories;
using AbstractFactoryProject.Equipment.Engines;
using AbstractFactoryProject.Equipment.Suspensions;
using AbstractFactoryProject.Equipment.Wheels;

namespace AbstractFactoryProject
{
    public class Car
    {
        private IEngine _engine;
        private IWheel _wheel;
        private ISuspensions _suspensions;

        public Car(ICarEquipmentFactory factory)
        {
            _engine = factory.CreateEngine();
            _wheel = factory.CreateWheel();
            _suspensions = factory.CreateSuspensions();
        }

        public IEngine Engine
        {
            get => _engine;
            set => _engine = value;
        }

        public IWheel Wheel
        {
            get => _wheel;
            set => _wheel = value;
        }

        public ISuspensions Suspensions
        {
            get => _suspensions;
            set => _suspensions = value;
        }
    }
}