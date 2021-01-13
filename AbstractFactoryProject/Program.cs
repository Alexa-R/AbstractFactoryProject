using System;

namespace AbstractFactoryProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var car1 = new Car(CarFactory.GetInstance().GetFactory("standart"));
            Console.WriteLine(car1.Wheel.ToString());
            Console.WriteLine(car1.Engine.ToString());
            Console.WriteLine(car1.Suspensions.ToString());

            var car2 = new Car(CarFactory.GetInstance().GetFactory("economy"));
            Console.WriteLine(car2.Wheel.ToString());
            Console.WriteLine(car2.Engine.ToString());
            Console.WriteLine(car2.Suspensions.ToString());

            var car3 = new Car(CarFactory.GetInstance().GetFactory("extra"));
            Console.WriteLine(car3.Wheel.ToString());
            Console.WriteLine(car3.Engine.ToString());
            Console.WriteLine(car3.Suspensions.ToString());
        }
    }
}