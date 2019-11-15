using System;
using Task_1.Enums;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //new GasCar(Manufacturer.Audi, Type.Coupe, "T9", 50000, 2017, 155, 0, 5.3f, 2, true, true, "gasoline", 50, 26),
            //new ElectricCar(Manufacturer.Tesla, Type.Coupe, "Model S", 85000, 2016, 241, 405, 2.5f, 5, true, true, "Lithium ion", 570, 220),
            //new GasCar(Manufacturer.Mitsubishi, Type.Hatchback, "Colt", 10000, 2014, 120, 50, 6.3f, 5, true, true, "gasoline", 50, 20),
            //new ElectricCar(Manufacturer.Nissan, Type.Hatchback, "Leaf", 15000, 2016, 241, 405, 2.5f, 5, true, true, "Lithium ion", 400, 180),

            DieselCar car = new DieselCar("Auto1", 2012, 10000, 220, 1,
                                           TransmissionType.Automatic, BodyType.Crossover, Manufacturer.Skoda, 
                                           100, 6, 3, 100);

            Console.WriteLine(" " + car.Name + " " + car.Year + " " + car.TankCapacity);

            Console.ReadLine();
        }
    }
}
