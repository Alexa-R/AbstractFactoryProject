using System.Collections.Generic;
using AbstractFactoryProject.CarEquipmentFactories;

namespace AbstractFactoryProject
{
    public class CarFactory
    {
        private static readonly CarFactory Instance = new CarFactory();
        private IDictionary<string, ICarEquipmentFactory> factories = new Dictionary<string, ICarEquipmentFactory>();

        private CarFactory()
        {
            factories.Add("economy", new EconomyCarEquipmentFactory());
            factories.Add("standart", new StandartCarEquipmentFactory());
            factories.Add("extra", new ExtraCarEquipmentFactory());
        }

        public static CarFactory GetInstance()
        {
            return Instance;
        }

        public ICarEquipmentFactory GetFactory(string key)
        {
            return factories[key];
        }
    }
}