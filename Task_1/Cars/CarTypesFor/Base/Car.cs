using System;
using Task_1.Enums;
using Task_1.Cars.Interfases;

namespace Task_1
{
    public abstract class Car: IElement
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public int MaxSpeed { get; set; }

        public int SeatsNumber { get; set; }

        //коробка передач
        public TransmissionType TransmissionType { get; set; }

        //тип кузова
        public BodyType BodyType { get; set; }

        //производитель
        public Manufacturer Manufacturer { get; set; }

        //расход топлива/энергии
        public int FuelConsumption { get; set; }

        public virtual void Run()
        {
            Console.WriteLine("Автомобиль");
        }
    }
}
