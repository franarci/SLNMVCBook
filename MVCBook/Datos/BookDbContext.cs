using MVCBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MVCBook.Datos
{
    public class BookDbContext : DbContext
    {
       public DbSet<Book> Books { get; set; }

       public BookDbContext() : base("KeyDB") { }
    }
}