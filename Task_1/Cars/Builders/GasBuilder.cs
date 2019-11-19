using System;
using Task_1.Enums;

namespace Task_1
{
    public class GasBuilder
    {
        private Gas _fuel;
        public GasBuilder()
        {
            _fuel = new Gas();
        }
        public GasBuilder SetId(Guid id)
        {
            _fuel.Id = id;
            return this;
        }
        public GasBuilder SetName(string name)
        {
            _fuel.Name = name;
            return this;
        }
        public GasBuilder SetYear(int year)
        {
            _fuel.Year = year;
            return this;
        }
        public GasBuilder SetPrice(int price)
        {
            _fuel.Price = price;
            return this;
        }
        public GasBuilder SetMaxSpeed(int maxSpeed)
        {
            _fuel.MaxSpeed = maxSpeed;
            return this;
        }
        public GasBuilder SetSeatsNumber(int seatsNumber)
        {
            _fuel.SeatsNumber = seatsNumber;
            return this;
        }
        public GasBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            _fuel.TransmissionType = transmissionType;
            return this;
        }
        public GasBuilder SetBodyType(BodyType bodyType)
        {
            _fuel.BodyType = bodyType;
            return this;
        }
        public GasBuilder SetManufacturer(Manufacturer manufacturer)
        {
            _fuel.Manufacturer = manufacturer;
            return this;
        }
        public GasBuilder SetFuelConsumption(int fuelConsumption)
        {
            _fuel.FuelConsumption = fuelConsumption;
            return this;
        }
        public GasBuilder SetTankCapacity(int tankCapacity)
        {
            _fuel.TankCapacity = tankCapacity;
            return this;
        }
        public GasBuilder SetNumberOfCylinders(int numberOfCylinders)
        {
            _fuel.NumberOfCylinders = numberOfCylinders;
            return this;
        }
        public GasBuilder SetEngineCapacity(int engineCapacity)
        {
            _fuel.EngineCapacity = engineCapacity;
            return this;
        }
        public Gas Build()
        {
            return _fuel;
        }
        public static implicit operator Gas(GasBuilder builder)
        {
            return builder._fuel;
        }
    }
}
