using Task_1.Enums;

namespace Task_1
{
    //дизельный
    class DieselCar : FuelCar
    {
        //тип топлива
        public const FuelType TypeFuel = FuelType.Diesel;

        public DieselCar(string name, int year, int price, int maxSpeed, int seatsNumber,
                         TransmissionType transmissionType, BodyType bodyType, Manufacturer manufacturer,
                         int tankCapacity, int numberOfCylinders, int engineCapacity, int fuelConsumption)
            : base(name, year, price, maxSpeed, seatsNumber,
                  transmissionType, bodyType, manufacturer,
                  tankCapacity, numberOfCylinders, engineCapacity, fuelConsumption)
        {
        }

        //public override string ToString()
        //{
        //    return "Gas car: " + base.ToString() + $", Fuel Type: {FuelType}, FuelTank Capacity: {FuelTankCapacity}, Fuel Economy: {FuelEconomy} ";
        //}
    }
}
