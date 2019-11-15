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
            var taksoPark = new TaksoParkStorage(new List<Car>());

            DieselCar dieselCar = new DieselCar("Auto1", 2012, 10000, 120, 1,
                                           TransmissionType.Automatic, BodyType.Crossover, Manufacturer.Skoda, 10, 
                                           100, 5, 5);


            ElectricCar electricCar = new ElectricCar("Auto2", 2013, 20000, 220, 2,
                                          TransmissionType.Robotic, BodyType.Minivan, Manufacturer.BMW, 8,
                                          "", new TimeSpan());

            HybridCar hybridCar = new HybridCar("Auto3", 2014, 30000, 320, 3,
                                          TransmissionType.Manual, BodyType.Sedan, Manufacturer.Nissan, 6,
                                          100, 3, 5, "", new TimeSpan());

            Console.WriteLine("Taksopark:");
            Console.WriteLine(" " + dieselCar.Name + " " + dieselCar.Year + " " + dieselCar.TankCapacity);
            Console.WriteLine(" " + electricCar.Name + " " + electricCar.Year + " " + electricCar.TypeBattery);
            Console.WriteLine(" " + hybridCar.Name + " " + hybridCar.Year + " " + hybridCar.TankCapacity + " " + electricCar.TypeBattery);

            taksoPark.AddCar(dieselCar);
            taksoPark.AddCar(electricCar);
            taksoPark.AddCar(hybridCar);

            Console.WriteLine();

            long carsSumPrice = taksoPark.CalculateCarsSumPrice(taksoPark.Items);
            Console.WriteLine($"Autopark sum price: ${carsSumPrice}" + "\r\n");

            Console.WriteLine("Finding for speeds:");
            IEnumerable<Car> carsBySpeed = taksoPark.FindSpeed(taksoPark.Items, 100, 190);
            if (carsBySpeed.Count() == 0)
                Console.WriteLine("No cars for speeds" + "\r\n");
            else foreach (Car car in carsBySpeed)
                    Console.WriteLine(car + "\r\n");

            Console.WriteLine("Sorting cars by fuel consumption:");
            IEnumerable<Car> sortedListFuel = taksoPark.SortFuel(taksoPark.Items);
            foreach (var car in sortedListFuel)
                Console.WriteLine(car + "\r\n");

            Console.ReadLine();
        }
    }
}
