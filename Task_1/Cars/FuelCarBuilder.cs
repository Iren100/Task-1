using Task_1.Cars.Interfases;

namespace Task_1
{
    public class FuelCarBuilder
    {
        private IFuel fuelCar;
        public FuelCarBuilder(IFuel fuelCar)
        {
            this.fuelCar = fuelCar;
        }
        public FuelCarBuilder SetTankCapacity(int tankCapacity)
        {
            fuelCar.TankCapacity = tankCapacity;
            return this;
        }
        public FuelCarBuilder SetNumberOfCylinders(int numberOfCylinders)
        {
            fuelCar.NumberOfCylinders = numberOfCylinders;
            return this;
        }
        public FuelCarBuilder SetEngineCapacity(int engineCapacity)
        {
            fuelCar.EngineCapacity = engineCapacity;
            return this;
        }
        public FuelCarBuilder SetFuelConsumption(int fuelConsumption)
        {
            fuelCar.FuelConsumption = fuelConsumption;
            return this;
        }
        public IFuel Build()
        {
            return fuelCar;
        }
    }
}
