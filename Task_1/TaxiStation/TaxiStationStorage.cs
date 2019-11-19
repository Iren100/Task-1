using System;
using System.Collections.Generic;
using System.Linq;
using Task_1.Cars.Interfases;

namespace Task_1.Cars
{
    public class TaxiStationStorage: ITaxiStationStorage, IList
    {
        public ICollection<Car> Items { get; private set; }

        public TaxiStationStorage(ICollection<Car> items)
        {
            Items = items;
        }

        #region Operations

        public void AddCar(Car car)
        {
            Items.Add(car);
        }

        public void AddCars(IEnumerable<Car> cars)
        {
            var listCar = Items.ToList();
            listCar.AddRange(cars);
            Items = listCar;
        }

        public void RemoveCar(Guid id)
        {
            Items.Remove(FindCarById(id));
        }

        public Car FindCarById(Guid id)
        {
            return Items.Where(f => f.Id == id).First();
        }

        public IEnumerable<Car> FindCarsByName(string name)
        {
            return Items.Where(f => f.Name == name).ToList();
        }

        public decimal CalculateCarsSumPrice()
        {
            long sum = 0;
            foreach (Car car in Items)
                sum = sum + car.Price;
            return sum;
        }

        public IEnumerable<Car> FindCarsBySpeed(int min, int max)
        {
            List<Car> carSelection = new List<Car>();
            foreach (Car car in Items)
            {
                if (car.MaxSpeed >= min && car.MaxSpeed <= max)
                    carSelection.Add(car);
            }
            return carSelection;
        }

        public IEnumerable<Car> SortCarsByFuel()
        {
            List<Car> Cars = new List<Car>();
            if (Items.Count() == 0)
                Console.WriteLine("No cars!");

            foreach (Car car in Items)
                Cars.Add(car);

            Cars.Sort((car1, car2) => car1.FuelConsumption.CompareTo(car2.FuelConsumption));
            return Cars;
        }

        #endregion
    }
}
