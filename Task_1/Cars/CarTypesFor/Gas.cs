using System;
using Task_1.Enums;

namespace Task_1
{
    public class Gas : Fuel
    {
        public const FuelType TypeFuel = FuelType.Gas;

        public override void Run()
        {
            Console.WriteLine("Car on gas");
        }
    }
}
