using Task_1.Cars.Interfases;

namespace Task_1.Cars
{
    public static class CarBuilders
    {
        //Fluent Builders
        public static CarBuilder CreateCarBuilder(Car car)
        {
            return new CarBuilder(car);
        }
        public static FuelCarBuilder CreateFuelCarBuilder(IFuel fuelCar)
        {
            return new FuelCarBuilder(fuelCar);
        }
        public static ElectricCarBuilder CreateElectricCarBuilder(IElectric electricCar)
        {
            return new ElectricCarBuilder(electricCar);
        }
    }
}
