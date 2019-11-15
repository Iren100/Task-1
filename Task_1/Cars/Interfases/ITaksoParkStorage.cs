using System;
using System.Collections.Generic;

namespace Task_1.Cars.Interfases
{
    interface ITaksoParkStorage
    {
        void AddCar(Car car);

        void RemoveCar(Guid id);

        Car CarFindById(Guid id);

        IEnumerable<Car> CarsFindByName(string name);

        long CalculateCarsSumPrice(IEnumerable<Car> cars);

        IEnumerable<Car> FindSpeed(IEnumerable<Car> cars, int min, int max);

        IEnumerable<Car> SortFuel(IEnumerable<Car> cars);       
    }
}
