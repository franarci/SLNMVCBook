using MVCBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBook.Datos
{
    public class BookInitializer : DropCreateDatabaseAlways<BookDbContext>
    {

        protected override void Seed(BookDbContext context)
        {
            var books = new List<Book>
            {
               new Book
               {
                  Name = "It",
                  Author = "Stephen King",
                  PagesNumber = 5000,
                  Price = 250,
                  PriceConfirm=250,
                  Publisher ="Publisher",
                  PublicationDate="1978-05-05"
               }
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}