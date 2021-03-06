using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetById(Car car);

    }
}
