using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVCBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Author { get; set; }
        [Range(100, 10000, ErrorMessage = "The field PagesNumber must be between 100 and 10000")]
        public int PagesNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string Publisher { get; set; }
        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$", ErrorMessage = "Ingrese un formato de fecha válido, Por ejemplo: 2017-06-16 ")]
        public string PublicationDate { get; set; }
        public string Content { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        [Compare("Price")]
        [NotMapped]
        public decimal PriceConfirm { get; set; }
    }
}