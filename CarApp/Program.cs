using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car($"Brand {i + 1}", 2020 + i, 2.0 + i);
                cars[i].Start();
            }

            foreach (var car in cars)
            {
                car.DisplayInformation();
                Console.WriteLine();
            }

            double increment = 0.5;
            cars[0].IncreaseEngineCapacity(ref increment);
            Console.WriteLine($"Engine capacity of car 1 increased to {cars[0].EngineCapacity} liters");

            Console.WriteLine($"Total number of cars: {Car.TotalCars}");
        }
    }
}
