using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }
        public int PagesNumber { get; set; }
        public string Publisher { get; set; }
        public string PublicationDate { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
        public decimal PriceConfirm { get; set; }
    }
}