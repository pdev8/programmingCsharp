using System;
using Unity;

namespace CSP.Unity
{
    public interface ICarKey
    {
    }

    public class BMWKey : ICarKey
    {
    }

    public class AudiKey : ICarKey
    {
    }

    public class FordKey : ICarKey
    {
    }

    public class Driver2
    {
        private ICar car = null;
        private ICarKey carKey = null;

        public Driver2(ICar car, ICarKey carKey)
        {
            this.car = car;
            this.carKey = carKey;
        }

        public void RunCar()
        {
            Console.WriteLine($"Running {this.car.GetType().Name} with {this.carKey.GetType().Name} - {this.car.Run()} mile");
        }
    }

    public class UnityContainerExample2
    {
        public static void Run()
        {
            var container = new UnityContainer();

            container.RegisterType<ICarKey, AudiKey>();
            container.RegisterType<ICar, Audi>();

            var driver2 = container.Resolve<Driver2>();

            driver2.RunCar();
        }
    }
}