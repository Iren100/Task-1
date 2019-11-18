using System;
using Task_1.Cars.Interfases;
using Task_1.Enums;

namespace Task_1
{
    public class Bus : GasCar, IPassenger
    {
        private const int passengers = 6;

        public Bus(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer, int fuelConsumption,
                         int tankCapacity, int numberOfCylinders, int engineCapacity)
            : base(name, year, price, maxSpeed, seatsNumber,
                  transmissionType, bodyType, manufacturer, fuelConsumption,
                  tankCapacity, numberOfCylinders, engineCapacity)
        {
        }

        int IPassenger.PassengerCount()
        {
            return passengers;
        }

        public override void Run()
        {
            Console.WriteLine("Пассажирский автомобиль");
        }
        
    }
}
