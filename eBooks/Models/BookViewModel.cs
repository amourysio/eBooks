using eBooks.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace eBooks.Models
{
    public class BookViewModel
    {
        [Key]
        public int Id { get; set; }

        public string BookPictureURL { get; set; }
        public string BookName { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
