using System;
using System.Collections.Generic;

namespace Task_1.Cars.Interfases
{
    interface ITaxiStationStorage
    {
        void AddCar(Car car);

        void AddCars(IEnumerable<Car> cars);

        void RemoveCar(Guid id);

        Car FindCarById(Guid id);

        IEnumerable<Car> FindCarsByName(string name);

        decimal CalculateCarsSumPrice();

        IEnumerable<Car> FindCarsBySpeed(int min, int max);

        IEnumerable<Car> SortCarsByFuel();       
    }
}
