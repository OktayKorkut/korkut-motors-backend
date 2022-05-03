using System;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IEntitiyRepository<T>
    {

        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void GetById(T entity);
   
    }
}
