using CmScreen.Domain.Interfaces;
using CmScreen.Domain.Models;
using CmScreen.Infra.Data.ContextDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmScreen.Infra.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private CmScreenDbContext _context = null;
        private DbSet<T> table = null;
        //public GenericRepository()
        //{
        //    this._context = new CmScreenDbContext();
        //    table = _context.Set<T>();
        //}
        public GenericRepository(CmScreenDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
