using MVCBook.Datos;
using MVCBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBook.Controllers
{
    public class BookController : Controller
    {

        private BookDbContext context = new BookDbContext();

        public ActionResult Index()
        {
            var books = context.Books.ToList();


            return View("Index", books);
        }

        public ActionResult Create()
        {
            Book book = new Book();

            return View("Create", book);
        }


        //Book/Create --> POST
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", book);
        }
    }
}