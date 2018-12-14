using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSP.PluralSight.LearningLINQ.LINQCar
{
    public class CarsMain
    {
        public static void Run()
        {
            var cars = ProcessFile("Pluralsight/LearningLINQ/LINQCar/fuel.csv");

            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }
        }

        private static List<Car> ProcessFile(string path)
        {
            return File.ReadAllLines(path).Skip(1).Where(s => s.Length > 1).Select(Car.ParseFromCsv).ToList();
        }
    }
}
