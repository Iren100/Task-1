using System.Collections.Generic;

namespace Task_1.Cars.Interfases
{
    interface ICarList
    {
        ICollection<Car> Items { get; }
    }
}
