using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;
using Task_1.Cars;

namespace Task_1
{
    //авто на топливе
    public class FuelCar : Car, IFuel
    {   
        public int TankCapacity { get; set; }
        public int NumberOfCylinders { get; set; }
        public int EngineCapacity { get; set; }

        public FuelCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer, int fuelConsumption,
                         int tankCapacity, int numberOfCylinders, int engineCapacity)
        {
            CarBuilders.CreateCarBuilder(this).SetName(name).SetYear(year).SetPrice(price).SetMaxSpeed(maxSpeed).SeatsNumber(seatsNumber)
                                    .SetTransmissionType(TransmissionType).SetBodyType(BodyType).SetManufacturer(manufacturer).SetFuelConsumption(fuelConsumption).Build();
            CarBuilders.CreateFuelCarBuilder(this).SetTankCapacity(tankCapacity).SetNumberOfCylinders(numberOfCylinders)
                                        .SetEngineCapacity(engineCapacity).Build();
        }

        public override void Run()
        {
            Console.WriteLine("Авто на топливе");
        }
    }
}
