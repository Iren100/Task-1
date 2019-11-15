using System;

namespace Task_1.Cars.Interfases
{
    public interface IElement
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
