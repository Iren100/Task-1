using System;

namespace Task_1.Cars.Interfases
{
    //электрическое авто
    interface IElectric
    {
        //тип батареи
        String TypeBattery { get; set; }

        //срок службы батареи
        TimeSpan LifeBattery { get; set; }
    }
}
