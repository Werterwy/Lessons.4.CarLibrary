using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public partial class Car
    {
        private string brand;
        private int yearManufactured;
        private double engineCapacity;
        private bool isRunning;
        private static int totalCars;

        public Car()
        {
            brand = "Unknown";
            yearManufactured = DateTime.Now.Year;
            engineCapacity = 2.0;
            isRunning = false;
            totalCars++;
        }

        public Car(string brand, int year, double engine)
        {
            this.brand = brand;
            yearManufactured = year;
            engineCapacity = engine;
            isRunning = false;
            totalCars++;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string newBrand)
        {
            brand = newBrand;
        }

        public int GetYearManufactured()
        {
            return yearManufactured;
        }

        public void SetYearManufactured(int newYear)
        {
            yearManufactured = newYear;
        }

        public void Start()
        {
            isRunning = true;
        }

        public void Stop()
        {
            isRunning = false;
        }

        public void IncreaseEngineCapacity(ref double increment)
        {
            engineCapacity += increment;
        }

        public static int TotalCars
        {
            get { return totalCars; }
        }

        public double EngineCapacity
        {
            get { return engineCapacity; }
        }

        static Car()
        {
            totalCars = 0;
        }

        public Car(string brand, int yearManufactured, double engineCapacity, bool isRunning) : this(brand, yearManufactured, engineCapacity)
        {
            this.isRunning = isRunning;
        }
    }
    public partial class Car
    {
        public void DisplayInformation()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year Manufactured: {yearManufactured}");
            Console.WriteLine($"Engine Capacity: {engineCapacity} liters");
            Console.WriteLine($"Is Running: {(isRunning ? "Yes" : "No")}");
        }
    }
}
