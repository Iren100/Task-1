using System;
using Task_1.Enums;

namespace Task_1
{
    //дизельный
    public class DieselCar : FuelCar
    {
        //тип топлива
        public const FuelType TypeFuel = FuelType.Diesel;

        public DieselCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer, int fuelConsumption,
                         int tankCapacity, int numberOfCylinders, int engineCapacity)
            : base(name, year, price, maxSpeed, seatsNumber,
                  transmissionType, bodyType, manufacturer, fuelConsumption,
                  tankCapacity, numberOfCylinders, engineCapacity)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Дизельный авто");
        }
    }
}
