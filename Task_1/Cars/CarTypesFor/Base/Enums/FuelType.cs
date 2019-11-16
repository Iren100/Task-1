using System;

namespace Task_1.Enums
{
    /// <summary>
    /// Тип кузова
    /// </summary>
    [Flags]
    public enum FuelType
    {
        /// <summary>
        /// Бензин
        /// </summary>
        Gasoline = 1,
        /// <summary>
        /// Газ
        /// </summary>
        Gas = 2,
        /// <summary>
        /// Дизельное
        /// </summary>
        Diesel = 3      
    }
}
