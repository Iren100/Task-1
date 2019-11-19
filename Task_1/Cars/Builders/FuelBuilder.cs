using System;
using Task_1.Enums;

namespace Task_1
{
    public class FuelBuilder<T> where T : Fuel, new()
    {
        private T _fuel;
        public FuelBuilder()
        {
            _fuel = new T();
        }
        public FuelBuilder<T> SetId(Guid id)
        {
            _fuel.Id = id;
            return this;
        }
        public FuelBuilder<T> SetName(string name)
        {
            _fuel.Name = name;
            return this;
        }
        public FuelBuilder<T> SetYear(int year)
        {
            _fuel.Year = year;
            return this;
        }
        public FuelBuilder<T> SetPrice(int price)
        {
            _fuel.Price = price;
            return this;
        }
        public FuelBuilder<T> SetMaxSpeed(int maxSpeed)
        {
            _fuel.MaxSpeed = maxSpeed;
            return this;
        }
        public FuelBuilder<T> SetSeatsNumber(int seatsNumber)
        {
            _fuel.SeatsNumber = seatsNumber;
            return this;
        }
        public FuelBuilder<T> SetTransmissionType(TransmissionType transmissionType)
        {
            _fuel.TransmissionType = transmissionType;
            return this;
        }
        public FuelBuilder<T> SetBodyType(BodyType bodyType)
        {
            _fuel.BodyType = bodyType;
            return this;
        }
        public FuelBuilder<T> SetManufacturer(Manufacturer manufacturer)
        {
            _fuel.Manufacturer = manufacturer;
            return this;
        }
        public FuelBuilder<T> SetFuelConsumption(int fuelConsumption)
        {
            _fuel.FuelConsumption = fuelConsumption;
            return this;
        }
        public FuelBuilder<T> SetTankCapacity(int tankCapacity)
        {
            _fuel.TankCapacity = tankCapacity;
            return this;
        }
        public FuelBuilder<T> SetNumberOfCylinders(int numberOfCylinders)
        {
            _fuel.NumberOfCylinders = numberOfCylinders;
            return this;
        }
        public FuelBuilder<T> SetEngineCapacity(int engineCapacity)
        {
            _fuel.EngineCapacity = engineCapacity;
            return this;
        }
        public T Build()
        {
            return _fuel;
        }
        public static implicit operator T(FuelBuilder<T> builder)
        {
            return builder._fuel;
        }
    }
}
