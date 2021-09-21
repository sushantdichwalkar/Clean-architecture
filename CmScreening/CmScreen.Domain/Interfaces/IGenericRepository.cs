using CmScreen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
