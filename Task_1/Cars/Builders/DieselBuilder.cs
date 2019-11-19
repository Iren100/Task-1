using System;
using Task_1.Enums;

namespace Task_1
{
    public class DieselBuilder
    {
        private Diesel _fuel;
        public DieselBuilder()
        {
            _fuel = new Diesel();
        }
        public DieselBuilder SetId(Guid id)
        {
            _fuel.Id = id;
            return this;
        }
        public DieselBuilder SetName(string name)
        {
            _fuel.Name = name;
            return this;
        }
        public DieselBuilder SetYear(int year)
        {
            _fuel.Year = year;
            return this;
        }
        public DieselBuilder SetPrice(int price)
        {
            _fuel.Price = price;
            return this;
        }
        public DieselBuilder SetMaxSpeed(int maxSpeed)
        {
            _fuel.MaxSpeed = maxSpeed;
            return this;
        }
        public DieselBuilder SetSeatsNumber(int seatsNumber)
        {
            _fuel.SeatsNumber = seatsNumber;
            return this;
        }
        public DieselBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            _fuel.TransmissionType = transmissionType;
            return this;
        }
        public DieselBuilder SetBodyType(BodyType bodyType)
        {
            _fuel.BodyType = bodyType;
            return this;
        }
        public DieselBuilder SetManufacturer(Manufacturer manufacturer)
        {
            _fuel.Manufacturer = manufacturer;
            return this;
        }
        public DieselBuilder SetFuelConsumption(int fuelConsumption)
        {
            _fuel.FuelConsumption = fuelConsumption;
            return this;
        }
        public DieselBuilder SetTankCapacity(int tankCapacity)
        {
            _fuel.TankCapacity = tankCapacity;
            return this;
        }
        public DieselBuilder SetNumberOfCylinders(int numberOfCylinders)
        {
            _fuel.NumberOfCylinders = numberOfCylinders;
            return this;
        }
        public DieselBuilder SetEngineCapacity(int engineCapacity)
        {
            _fuel.EngineCapacity = engineCapacity;
            return this;
        }
        public Diesel Build()
        {
            return _fuel;
        }
        public static implicit operator Diesel(DieselBuilder builder)
        {
            return builder._fuel;
        }
    }
}
