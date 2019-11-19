using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;

namespace Task_1
{
    public class Car: IElement
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public int MaxSpeed { get; set; }

        public int SeatsNumber { get; set; }

        public TransmissionType TransmissionType { get; set; }

        public BodyType BodyType { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public int FuelConsumption { get; set; }

        public virtual void Run()
        {
            Console.WriteLine("Car");
        }
    }
}
