namespace AbstractFactoryProject.Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var car1 = new Car(CarFactory.GetInstance().GetFactory("standart"));

            var car2 = new Car(CarFactory.GetInstance().GetFactory("economy"));

            var car3 = new Car(CarFactory.GetInstance().GetFactory("extra"));
        }
    }
}