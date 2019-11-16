using System;
using System.Collections.Generic;
using System.Linq;
using Task_1.Cars.Interfases;

namespace Task_1.Cars
{
    public class TaksoParkStorage: ITaksoParkStorage, ICarList
    {
        public ICollection<Car> Items { get; private set; }

        public TaksoParkStorage(ICollection<Car> items)
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
            Items.Remove(CarFindById(id));
        }

        public Car CarFindById(Guid id)
        {
            return Items.Where(f => f.Id == id).First();
        }

        public IEnumerable<Car> CarsFindByName(string name)
        {
            return Items.Where(f => f.Name == name).ToList();
        }

        public long CalculateCarsSumPrice(IEnumerable<Car> cars)
        {
            long sum = 0;
            foreach (Car car in cars)
                sum = sum + car.Price;
            return sum;
        }

        public IEnumerable<Car> FindSpeed(IEnumerable<Car> cars, int min, int max)
        {
            List<Car> carSelection = new List<Car>();
            foreach (Car car in cars)
            {
                if (car.MaxSpeed >= min && car.MaxSpeed <= max)
                    carSelection.Add(car);
            }
            return carSelection;
        }

        public IEnumerable<Car> SortFuel(IEnumerable<Car> cars)
        {
            List<Car> Cars = new List<Car>();
            if (cars.Count() == 0)
                Console.WriteLine("No cars!");

            foreach (Car car in cars)
                Cars.Add(car);

            Cars.Sort((car1, car2) => car1.FuelConsumption.CompareTo(car2.FuelConsumption));
            return Cars;
        }

        #endregion
    }
}
