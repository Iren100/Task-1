using System;

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
