using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;

namespace Task_1
{
    //гибридный
    class HybridCar : FuelCar, IElectric
    {
        public string TypeBattery { get; set; }
        public TimeSpan LifeBattery { get; set; }

        public HybridCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer, int fuelConsumption,
                         int tankCapacity, int numberOfCylinders, int engineCapacity,
                         string typeBattery, TimeSpan lifeBattery)
            : base(name, year, price, maxSpeed, seatsNumber,
                  transmissionType, bodyType, manufacturer, fuelConsumption,
                  tankCapacity, numberOfCylinders, engineCapacity)
        {
            CreateElectricCarBuilder(this).SetTypeBattery("Battery1").SetLifeBattery(new TimeSpan()).Build();
        }

        //Fluent Builder
        public static ElectricCarBuilder CreateElectricCarBuilder(IElectric electricCar)
        {
            return new ElectricCarBuilder(electricCar);
        }
    }
}
