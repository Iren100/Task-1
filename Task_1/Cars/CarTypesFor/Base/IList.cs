using System.Collections.Generic;

namespace Task_1.Cars.Interfases
{
    interface IList
    {
        ICollection<Car> Items { get; }
    }
}
