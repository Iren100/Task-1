using System;
using Task_1.Cars.Interfases;
using Task_1.Enums;

namespace Task_1
{
    public class Bus : Gas, IPassenger
    {
        private const int _passengers = 6;

        int IPassenger.PassengerCount()
        {
            return _passengers;
        }

        public override void Run()
        {
            Console.WriteLine("Passenger car");
        }
        
    }
}
