using System.Collections.Generic;

namespace CarLibrary
{
    public class CarManager
    {
        private List<Car> cars = new List<Car>();

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public List<Car> GetCars()
        {
            return cars;
        }
    }
}
