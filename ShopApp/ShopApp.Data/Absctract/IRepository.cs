using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Data.Absctract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T Entity);
    }
}
