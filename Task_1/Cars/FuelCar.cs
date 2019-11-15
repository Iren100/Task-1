using Task_1.Enums;
using Task_1.Cars.Interfases;

namespace Task_1
{
    //дизельный
    class FuelCar : Car, IFuel
    {   
        public int TankCapacity { get; set; }
        public int NumberOfCylinders { get; set; }
        public int EngineCapacity { get; set; }
        public int FuelConsumption { get; set; }

        public FuelCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer,
                         int tankCapacity, int numberOfCylinders, int engineCapacity, int fuelConsumption)
        {
            CreateCarBuilder(this).SetName(name).SetYear(year).SetPrice(price).SetMaxSpeed(maxSpeed).SeatsNumber(seatsNumber)
                                    .SetTransmissionType(TransmissionType).SetBodyType(BodyType).SetManufacturer(manufacturer).Build();
            CreateFuelCarBuilder(this).SetTankCapacity(tankCapacity).SetNumberOfCylinders(numberOfCylinders)
                                        .SetEngineCapacity(engineCapacity).SetFuelConsumption(fuelConsumption).Build();
        }

        //Fluent Builder
        public static CarBuilder CreateCarBuilder(Car car)
        {
            return new CarBuilder(car);
        }
        //Fluent Builder
        public static FuelCarBuilder CreateFuelCarBuilder(IFuel fuelCar)
        {
            return new FuelCarBuilder(fuelCar);
        }

        //public override string ToString()
        //{
        //    return "Gas car: " + base.ToString() + $", Fuel Type: {FuelType}, FuelTank Capacity: {FuelTankCapacity}, Fuel Economy: {FuelEconomy} ";
        //}
    }
}
