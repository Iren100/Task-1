using System;
using Task_1.Enums;

namespace Task_1
{
    public class Diesel : Fuel
    {
        public const FuelType TypeFuel = FuelType.Diesel;

        public override void Run()
        {
            Console.WriteLine("Diesel car");
        }
    }
}
