
namespace Task_1.Cars.Interfases
{
    //авто на топливе
    public interface IFuel
    {
        //емкость топливного бака
        int TankCapacity { get; set; }

        //кол-во цилиндров
        int NumberOfCylinders { get; set; }

        //объем двигателя
        int EngineCapacity { get; set; }
    }
}
