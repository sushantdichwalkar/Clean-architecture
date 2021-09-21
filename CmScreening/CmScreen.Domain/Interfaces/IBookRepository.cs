using CmScreen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book Get(Book order);
    }
}
