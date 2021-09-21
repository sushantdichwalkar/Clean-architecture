using CmScreen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmScreen.Infra.Data.ContextDB
{
    public class CmScreenDbContext:DbContext
    {
        public CmScreenDbContext(DbContextOptions options) : base(options)
        {
        }

         public DbSet<Course> Courses { get; set; }
        public DbSet<Book> Books { get; set; }

        internal IQueryable<T> GetTable<T>()
        {
            throw new NotImplementedException();
        }
    }
}
