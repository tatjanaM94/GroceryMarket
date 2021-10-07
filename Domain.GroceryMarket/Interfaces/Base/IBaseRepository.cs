using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.GroceryMarket.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        // crud methods
        IReadOnlyList<T> GetAll();
        T GetById(Guid id);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
