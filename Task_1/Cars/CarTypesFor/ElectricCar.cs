using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;
using Task_1.Cars;

namespace Task_1
{
    public class ElectricCar : Car, IElectric
    {
        public string TypeBattery { get; set; }
        public TimeSpan LifeBattery { get; set; }

        public ElectricCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer, int fuelConsumption,
                         string typeBattery, TimeSpan lifeBattery)
        {
            CarBuilders.CreateCarBuilder(this).SetName(name).SetYear(year).SetPrice(price).SetMaxSpeed(maxSpeed).SeatsNumber(seatsNumber)
                                   .SetTransmissionType(TransmissionType).SetBodyType(BodyType).SetManufacturer(manufacturer)
                                   .SetFuelConsumption(fuelConsumption).Build();
            CarBuilders.CreateElectricCarBuilder(this).SetTypeBattery("Battery1").SetLifeBattery(new TimeSpan()).Build();
        }

        public override void Run()
        {
            Console.WriteLine("Электрическое авто");
        }
    }
}
