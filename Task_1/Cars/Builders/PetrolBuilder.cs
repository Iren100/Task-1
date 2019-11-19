using System;
using Task_1.Enums;

namespace Task_1
{
    public class PetrolBuilder
    {
        private Petrol _fuel;
        public PetrolBuilder()
        {
            _fuel = new Petrol();
        }
        public PetrolBuilder SetId(Guid id)
        {
            _fuel.Id = id;
            return this;
        }
        public PetrolBuilder SetName(string name)
        {
            _fuel.Name = name;
            return this;
        }
        public PetrolBuilder SetYear(int year)
        {
            _fuel.Year = year;
            return this;
        }
        public PetrolBuilder SetPrice(int price)
        {
            _fuel.Price = price;
            return this;
        }
        public PetrolBuilder SetMaxSpeed(int maxSpeed)
        {
            _fuel.MaxSpeed = maxSpeed;
            return this;
        }
        public PetrolBuilder SetSeatsNumber(int seatsNumber)
        {
            _fuel.SeatsNumber = seatsNumber;
            return this;
        }
        public PetrolBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            _fuel.TransmissionType = transmissionType;
            return this;
        }
        public PetrolBuilder SetBodyType(BodyType bodyType)
        {
            _fuel.BodyType = bodyType;
            return this;
        }
        public PetrolBuilder SetManufacturer(Manufacturer manufacturer)
        {
            _fuel.Manufacturer = manufacturer;
            return this;
        }
        public PetrolBuilder SetFuelConsumption(int fuelConsumption)
        {
            _fuel.FuelConsumption = fuelConsumption;
            return this;
        }
        public PetrolBuilder SetTankCapacity(int tankCapacity)
        {
            _fuel.TankCapacity = tankCapacity;
            return this;
        }
        public PetrolBuilder SetNumberOfCylinders(int numberOfCylinders)
        {
            _fuel.NumberOfCylinders = numberOfCylinders;
            return this;
        }
        public PetrolBuilder SetEngineCapacity(int engineCapacity)
        {
            _fuel.EngineCapacity = engineCapacity;
            return this;
        }
        public Petrol Build()
        {
            return _fuel;
        }
        public static implicit operator Petrol(PetrolBuilder builder)
        {
            return builder._fuel;
        }
    }
}
