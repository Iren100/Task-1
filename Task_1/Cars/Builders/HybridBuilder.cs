using System;
using Task_1.Enums;

namespace Task_1
{
    public class HybridBuilder
    {
        private Hybrid _hybrid;
        public HybridBuilder()
        {
            _hybrid = new Hybrid();
        }
        public HybridBuilder SetId(Guid id)
        {
            _hybrid.Id = id;
            return this;
        }
        public HybridBuilder SetName(string name)
        {
            _hybrid.Name = name;
            return this;
        }
        public HybridBuilder SetYear(int year)
        {
            _hybrid.Year = year;
            return this;
        }
        public HybridBuilder SetPrice(int price)
        {
            _hybrid.Price = price;
            return this;
        }
        public HybridBuilder SetMaxSpeed(int maxSpeed)
        {
            _hybrid.MaxSpeed = maxSpeed;
            return this;
        }
        public HybridBuilder SetSeatsNumber(int seatsNumber)
        {
            _hybrid.SeatsNumber = seatsNumber;
            return this;
        }
        public HybridBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            _hybrid.TransmissionType = transmissionType;
            return this;
        }
        public HybridBuilder SetBodyType(BodyType bodyType)
        {
            _hybrid.BodyType = bodyType;
            return this;
        }
        public HybridBuilder SetManufacturer(Manufacturer manufacturer)
        {
            _hybrid.Manufacturer = manufacturer;
            return this;
        }
        public HybridBuilder SetFuelConsumption(int fuelConsumption)
        {
            _hybrid.FuelConsumption = fuelConsumption;
            return this;
        }
        public HybridBuilder SetTankCapacity(int tankCapacity)
        {
            _hybrid.TankCapacity = tankCapacity;
            return this;
        }
        public HybridBuilder SetNumberOfCylinders(int numberOfCylinders)
        {
            _hybrid.NumberOfCylinders = numberOfCylinders;
            return this;
        }
        public HybridBuilder SetEngineCapacity(int engineCapacity)
        {
            _hybrid.EngineCapacity = engineCapacity;
            return this;
        }
        public HybridBuilder SetTypeBattery(string typeBattery)
        {
            _hybrid.TypeBattery = typeBattery;
            return this;
        }
        public HybridBuilder SetLifeBattery(TimeSpan lifeBattery)
        {
            _hybrid.LifeBattery = lifeBattery;
            return this;
        }
        public Hybrid Build()
        {
            return _hybrid;
        }
        public static implicit operator Hybrid(HybridBuilder builder)
        {
            return builder._hybrid;
        }
    }
}
