using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CmScreen.Application.Interfaces;
using CmScreen.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CmScreen.MVC.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            BookViewModel model = _bookService.GetAll();

            return View(model);
        }
    }
}