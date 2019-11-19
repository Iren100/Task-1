using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;
using Task_1.Cars;

namespace Task_1
{
    public class Hybrid : Fuel
    {
        public string TypeBattery { get; set; }
        public TimeSpan LifeBattery { get; set; }

        public override void Run()
        {
            Console.WriteLine("Hybrid car");
        }
    }
}
