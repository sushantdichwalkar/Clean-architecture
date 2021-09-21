using CmScreen.Application.Interfaces;
using CmScreen.Application.ViewModels;
using CmScreen.Domain.Interfaces;
using CmScreen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IGenericRepository<Book> _bookRepository;
        //IRepository<User> userRepository
        public BookService(IGenericRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public BookViewModel GetAll()
        {
            //Add this code snippet 
            return new BookViewModel()
            {
                Books = _bookRepository.GetAll()
            };
        }
               
        public Book Get(long id)
        {
            return _bookRepository.GetById(id);
        }
        public void Add(Book book)
        {
            _bookRepository.Insert(book);
            _bookRepository.Save();
            
        }
        public void Update(Book book)
        {
            _bookRepository.Update(book);
            _bookRepository.Save();
        }

       
    }
}
