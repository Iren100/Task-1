using System;
using Task_1.Enums;

namespace Task_1
{
    public class Petrol : Fuel
    {
        public const FuelType TypeFuel = FuelType.Gasoline;

        public override void Run()
        {
            Console.WriteLine("Gasoline car");
        }
    }
}
