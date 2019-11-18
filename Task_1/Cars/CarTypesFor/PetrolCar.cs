﻿using System;
using Task_1.Enums;

namespace Task_1
{
    public class PetrolCar : FuelCar
    {
        //тип топлива
        public const FuelType TypeFuel = FuelType.Gasoline;

        public PetrolCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer, int fuelConsumption,
                         int tankCapacity, int numberOfCylinders, int engineCapacity)
            : base(name, year, price, maxSpeed, seatsNumber,
                  transmissionType, bodyType, manufacturer, fuelConsumption,
                  tankCapacity, numberOfCylinders, engineCapacity)
        {
        }

        public override void Run()
        {
            Console.WriteLine("Бензиновое авто");
        }
    }
}
