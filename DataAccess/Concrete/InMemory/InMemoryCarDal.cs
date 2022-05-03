using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Brand="Mercedes"},
                new Car {Brand="BMW"},
                new Car {Brand="Audi"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public Car GetById(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _cars.SingleOrDefault(c=> c.Brand ==car.Brand);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
