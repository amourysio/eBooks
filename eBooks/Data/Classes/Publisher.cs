using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBooks.Data
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
