using System;
using System.Linq;
using System.Collections.Generic;
using Task_1.Enums;
using Task_1.Cars;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxiStorage = new TaxiStationStorage(new List<Car>());

            Guid id = new Guid();

            Fuel dieselCar = new FuelBuilder().SetId(id).SetName("Auto1").SetYear(2012).SetPrice(10000).SetMaxSpeed(120)
                .SetSeatsNumber(1).SetTransmissionType(TransmissionType.Automatic).SetBodyType(BodyType.Crossover)
                .SetManufacturer(Manufacturer.Skoda).SetFuelConsumption(10).SetTankCapacity(5).SetNumberOfCylinders(4).SetEngineCapacity(100);

            Electric electricCar = new ElectricBuilder().SetId(new Guid()).SetName("Auto2").SetYear(2013).SetPrice(20000).SetMaxSpeed(220)
                .SetSeatsNumber(2).SetTransmissionType(TransmissionType.Robotic).SetBodyType(BodyType.Minivan)
                .SetManufacturer(Manufacturer.BMW).SetFuelConsumption(8).SetTypeBattery("").SetLifeBattery(new TimeSpan());


            Fuel hybridCar = new FuelBuilder().SetId(new Guid()).SetName("Auto3").SetYear(2014).SetPrice(30000).SetMaxSpeed(320)
                .SetSeatsNumber(3).SetTransmissionType(TransmissionType.Manual).SetBodyType(BodyType.Sedan)
                .SetManufacturer(Manufacturer.Nissan).SetFuelConsumption(6).SetTankCapacity(100).SetNumberOfCylinders(3).SetEngineCapacity(5);


            Console.WriteLine("TaxiStorage:");
            Console.WriteLine(dieselCar.Name + " " + dieselCar.Year + " " + dieselCar.TankCapacity);
            Console.WriteLine(electricCar.Name + " " + electricCar.Year + " " + electricCar.TypeBattery);
            Console.WriteLine(hybridCar.Name + " " + hybridCar.Year + " " + hybridCar.TankCapacity + " " + electricCar.TypeBattery);

            taxiStorage.AddCars(new List<Car>() { dieselCar, electricCar, hybridCar });

            Console.WriteLine();

            decimal carsSumPrice = taxiStorage.CalculateCarsSumPrice();
            Console.WriteLine($"Autopark sum price: ${carsSumPrice}" + "\r\n");

            Console.WriteLine("Finding for speeds:");
            IEnumerable<Car> carsBySpeed = taxiStorage.FindCarsBySpeed(100, 190);
            if (carsBySpeed.Count() == 0)
            {
                Console.WriteLine("No cars for speeds" + "\r\n");
            }
            else foreach (Car car in carsBySpeed)
                {
                    Console.WriteLine(car.Name + "\r\n");
                }

            Console.WriteLine("Sorting cars by fuel consumption:");
            IEnumerable<Car> sortedListFuel = taxiStorage.SortCarsByFuel();
            foreach (var car in sortedListFuel)
            {
                Console.WriteLine(car.Name);
            }

            taxiStorage.RemoveCar(id);
            taxiStorage.AddCar(taxiStorage.FindCarById(id));

            Console.WriteLine();
            Console.WriteLine("TaxiStorage:");
            foreach (Car car in taxiStorage.Items)
            {
                car.Run();
            }

            Console.ReadLine();
        }
    }
}
