using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums;
using Task_1.Cars.Interfases;

namespace Task_1
{
    //гибридный
    class HybridCar : Car, IFuel, IElectric
    {
        //тип топлива
        //public const IEnumerable<FuelType> TypeFuel = new List ( FuelType.Gasoline, FuelType.Gas, FuelType.Diesel );

        public int TankCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfCylinders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int EngineCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FuelConsumption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string TypeBattery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TimeSpan LifeBattery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public HybridCar(Manufacturer manufacturer, int price, int year, int maxSpeed)
            : base()
        {

        //    TypeFuel = fuelType;
        //    TankCapacity = fuelTankCapacity;
        }

        
        //public override string ToString()
        //{
        //    return "Gas car: " + base.ToString() + $", Fuel Type: {FuelType}, FuelTank Capacity: {FuelTankCapacity}, Fuel Economy: {FuelEconomy} ";
        //}
    }
}
