using CmScreen.Application.ViewModels;
using CmScreen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetAll();

        Book Get(long id);
        void Add(Book user);
        void Update(Book user);
        
    }
}
