using System;
using Task_1.Enums;

namespace Task_1
{
    public class Builder
    {
        private Car _car;
        public Builder(Car car)
        {
            _car = car;
        }
        public Builder SetId(Guid id)
        {
            _car.Id = id;
            return this;
        }
        public Builder SetName(string name)
        {
            _car.Name = name;
            return this;
        }
        public Builder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }
        public Builder SetPrice(int price)
        {
            _car.Price = price;
            return this;
        }
        public Builder SetMaxSpeed(int maxSpeed)
        {
            _car.MaxSpeed = maxSpeed;
            return this;
        }
        public Builder SetSeatsNumber(int seatsNumber)
        {
            _car.SeatsNumber = seatsNumber;
            return this;
        }
        public Builder SetTransmissionType(TransmissionType transmissionType)
        {
            _car.TransmissionType = transmissionType;
            return this;
        }
        public Builder SetBodyType(BodyType bodyType)
        {
            _car.BodyType = bodyType;
            return this;
        }
        public Builder SetManufacturer(Manufacturer manufacturer)
        {
            _car.Manufacturer = manufacturer;
            return this;
        }
        public Builder SetFuelConsumption(int fuelConsumption)
        {
            _car.FuelConsumption = fuelConsumption;
            return this;
        }
        public Car Build()
        {
            return _car;
        }
        public static implicit operator Car(Builder builder)
        {
            return builder._car;
        }
    }
}
