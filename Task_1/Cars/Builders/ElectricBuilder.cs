using System;
using Task_1.Enums;

namespace Task_1
{
    public class ElectricBuilder
    {
        private Electric _electric;
        public ElectricBuilder()
        {
            _electric = new Electric();
        }
        public ElectricBuilder SetId(Guid id)
        {
            _electric.Id = id;
            return this;
        }
        public ElectricBuilder SetName(string name)
        {
            _electric.Name = name;
            return this;
        }
        public ElectricBuilder SetYear(int year)
        {
            _electric.Year = year;
            return this;
        }
        public ElectricBuilder SetPrice(int price)
        {
            _electric.Price = price;
            return this;
        }
        public ElectricBuilder SetMaxSpeed(int maxSpeed)
        {
            _electric.MaxSpeed = maxSpeed;
            return this;
        }
        public ElectricBuilder SetSeatsNumber(int seatsNumber)
        {
            _electric.SeatsNumber = seatsNumber;
            return this;
        }
        public ElectricBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            _electric.TransmissionType = transmissionType;
            return this;
        }
        public ElectricBuilder SetBodyType(BodyType bodyType)
        {
            _electric.BodyType = bodyType;
            return this;
        }
        public ElectricBuilder SetManufacturer(Manufacturer manufacturer)
        {
            _electric.Manufacturer = manufacturer;
            return this;
        }
        public ElectricBuilder SetFuelConsumption(int fuelConsumption)
        {
            _electric.FuelConsumption = fuelConsumption;
            return this;
        }
        public ElectricBuilder SetTypeBattery(string typeBattery)
        {
            _electric.TypeBattery = typeBattery;
            return this;
        }
        public ElectricBuilder SetLifeBattery(TimeSpan lifeBattery)
        {
            _electric.LifeBattery = lifeBattery;
            return this;
        }
        public Electric Build()
        {
            return _electric;
        }
        public static implicit operator Electric(ElectricBuilder builder)
        {
            return builder._electric;
        }
    }
}
