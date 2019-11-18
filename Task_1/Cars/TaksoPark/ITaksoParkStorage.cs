using System;
using System.Collections.Generic;

namespace Task_1.Cars.Interfases
{
    interface ITaksoParkStorage
    {
        void AddCar(Car car);

        void AddCars(IEnumerable<Car> cars);

        void RemoveCar(Guid id);

        Car CarFindById(Guid id);

        IEnumerable<Car> CarsFindByName(string name);

        long CalculateCarsSumPrice();

        IEnumerable<Car> FindSpeed(int min, int max);

        IEnumerable<Car> SortFuel();       
    }
}
