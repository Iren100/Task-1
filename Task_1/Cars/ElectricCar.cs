using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums;
using Task_1.Cars.Interfases;

namespace Task_1
{
    //электрический
    class ElectricCar : Car, IElectric
    {
       

     

        public string TypeBattery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TimeSpan LifeBattery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ElectricCar(Manufacturer manufacturer, int price, int year, int maxSpeed)
         : base()
        {

            //TypeBattery = fuelType;
            //LifeBattery = fuelTankCapacity;
        }

        //public override string ToString()
        //{
        //    return "Gas car: " + base.ToString() + $", Fuel Type: {FuelType}, FuelTank Capacity: {FuelTankCapacity}, Fuel Economy: {FuelEconomy} ";
        //}
    }
}
