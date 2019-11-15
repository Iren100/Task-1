using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;

namespace Task_1
{
    //электрический
    class ElectricCar : Car, IElectric
    {
        public string TypeBattery { get; set; }
        public TimeSpan LifeBattery { get; set; }

        public ElectricCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer, int fuelConsumption,
                         string typeBattery, TimeSpan lifeBattery)
        {
            CreateCarBuilder(this).SetName(name).SetYear(year).SetPrice(price).SetMaxSpeed(maxSpeed).SeatsNumber(seatsNumber)
                                   .SetTransmissionType(TransmissionType).SetBodyType(BodyType).SetManufacturer(manufacturer)
                                   .SetFuelConsumption(fuelConsumption).Build();
            CreateElectricCarBuilder(this).SetTypeBattery("Battery1").SetLifeBattery(new TimeSpan()).Build();
        }

        //Fluent Builder
        public static CarBuilder CreateCarBuilder(Car car)
        {
            return new CarBuilder(car);
        }
        //Fluent Builder
        public static ElectricCarBuilder CreateElectricCarBuilder(IElectric electricCar)
        {
            return new ElectricCarBuilder(electricCar);
        }
    }
}
