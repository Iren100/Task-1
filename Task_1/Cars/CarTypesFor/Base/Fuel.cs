using System;

namespace Task_1
{
    public class Fuel : Car
    {   
        public int TankCapacity { get; set; }
        public int NumberOfCylinders { get; set; }
        public int EngineCapacity { get; set; }

        public override void Run()
        {
            Console.WriteLine("Auto on fuel");
        }
    }
}
