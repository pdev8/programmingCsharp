using System;
using Unity;

namespace CSP.Unity
{
    public interface ICar
    {
        int Run();
    }

    public class BMW : ICar
    {
        private int _miles;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Ford : ICar
    {
        private int _miles;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Audi : ICar
    {
        private int _miles;

        public int Run()
        {
            return ++_miles;
        }
    }

    public class Driver
    {
        private ICar _car = null;

        public Driver(ICar car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine($"Running {_car.GetType().Name} - {_car.Run()}");
        }
    }

    public class UnityContainerExample
    {
        public static void Run()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>(); // Map ICar with BMW

            // Resolves dependencies and returns Driver object
            Driver drv = container.Resolve<Driver>();
            drv.RunCar();
        }
    }
}