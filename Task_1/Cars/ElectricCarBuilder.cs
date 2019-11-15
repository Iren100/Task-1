using System;
using Task_1.Cars.Interfases;

namespace Task_1
{
    public class ElectricCarBuilder
    {
        private IElectric ElectricCar;
        public ElectricCarBuilder(IElectric electricCar)
        {
            ElectricCar = electricCar;
        }
        public ElectricCarBuilder SetTypeBattery(string typeBattery)
        {
            ElectricCar.TypeBattery = typeBattery;
            return this;
        }
        public ElectricCarBuilder SetLifeBattery(TimeSpan lifeBattery)
        {
            ElectricCar.LifeBattery = lifeBattery;
            return this;
        }
        public IElectric Build()
        {
            return ElectricCar;
        }
    }
}
