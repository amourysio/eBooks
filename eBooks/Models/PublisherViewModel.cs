using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBooks.Models
{
    public class PublisherViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }

        public List<BookViewModel> Books { get; set; }
    }
}
