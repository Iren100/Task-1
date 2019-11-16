using Task_1.Enums;

namespace Task_1
{
    public class CarBuilder
    {
        private Car car;
        public CarBuilder(Car car)
        {
            this.car = car;
        }
        public CarBuilder SetName(string name)
        {
            car.Name = name;
            return this;
        }
        public CarBuilder SetYear(int year)
        {
            car.Year = year;
            return this;
        }
        public CarBuilder SetPrice(int price)
        {
            car.Price = price;
            return this;
        }
        public CarBuilder SetMaxSpeed(int maxSpeed)
        {
            car.MaxSpeed = maxSpeed;
            return this;
        }
        public CarBuilder SeatsNumber(int seatsNumber)
        {
            car.SeatsNumber = seatsNumber;
            return this;
        }
        public CarBuilder SetTransmissionType(TransmissionType transmissionType)
        {
            car.TransmissionType = transmissionType;
            return this;
        }
        public CarBuilder SetBodyType(BodyType bodyType)
        {
            car.BodyType = bodyType;
            return this;
        }
        public CarBuilder SetManufacturer(Manufacturer manufacturer)
        {
            car.Manufacturer = manufacturer;
            return this;
        }
        public CarBuilder SetFuelConsumption(int fuelConsumption)
        {
            car.FuelConsumption = fuelConsumption;
            return this;
        }
        public Car Build()
        {
            return car;
        }
    }
}
