using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;
using Task_1.Cars;

namespace Task_1
{
    public class HybridCar : FuelCar, IElectric
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
            CarBuilders.CreateElectricCarBuilder(this).SetTypeBattery("Battery1").SetLifeBattery(new TimeSpan()).Build();
        }

        public override void Run()
        {
            Console.WriteLine("Гибридное авто");
        }
    }
}
