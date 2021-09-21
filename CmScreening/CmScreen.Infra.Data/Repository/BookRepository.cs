using CmScreen.Domain.Interfaces;
using CmScreen.Domain.Models;
using CmScreen.Infra.Data.ContextDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Infra.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        public CmScreenDbContext _context;
        public BookRepository(CmScreenDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetAll()
        {
            // Add this line
            return _context.Books;
        }

        public Book Get(Book book)
        {
            return _context.Add(book).Entity;
        }
    }
}
