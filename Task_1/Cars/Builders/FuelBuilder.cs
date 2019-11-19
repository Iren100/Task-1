using System;
using Task_1.Enums;

namespace Task_1
{
    public class FuelBuilder
    {
        private Fuel _fuel;
        public FuelBuilder()
        {
            _fuel = new Fuel();
        }
        public FuelBuilder SetId(Guid id)
        {
            _fuel.Id = id;
            return this;
        }
        public FuelBuilder SetName(string name)
        {
            _fuel.Name = name;
            return this;
        }
        public FuelBuilder SetYear(int year)
        {
            _fuel.Year = year;
            return this;
        }
        public FuelBuilder SetPrice(int price)
        {
            _fuel.Price = price;
            return this;
        }
        public FuelBuilder SetMaxSpeed(int maxSpeed)
        {
            _fuel.MaxSpeed = maxSpeed;
            return this;
        }
        public FuelBuilder SetSeatsNumber(int seatsNumber)
        {
            _fuel.SeatsNumber = seatsNumber;
            return this;
        }
        public FuelBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            _fuel.TransmissionType = transmissionType;
            return this;
        }
        public FuelBuilder SetBodyType(BodyType bodyType)
        {
            _fuel.BodyType = bodyType;
            return this;
        }
        public FuelBuilder SetManufacturer(Manufacturer manufacturer)
        {
            _fuel.Manufacturer = manufacturer;
            return this;
        }
        public FuelBuilder SetFuelConsumption(int fuelConsumption)
        {
            _fuel.FuelConsumption = fuelConsumption;
            return this;
        }
        public FuelBuilder SetTankCapacity(int tankCapacity)
        {
            _fuel.TankCapacity = tankCapacity;
            return this;
        }
        public FuelBuilder SetNumberOfCylinders(int numberOfCylinders)
        {
            _fuel.NumberOfCylinders = numberOfCylinders;
            return this;
        }
        public FuelBuilder SetEngineCapacity(int engineCapacity)
        {
            _fuel.EngineCapacity = engineCapacity;
            return this;
        }
        public Fuel Build()
        {
            return _fuel;
        }
        public static implicit operator Fuel(FuelBuilder builder)
        {
            return builder._fuel;
        }
    }
}
