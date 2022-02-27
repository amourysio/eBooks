using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBooks.Models
{
    public class AuthorViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        public List<BookViewModel> Books { get; set; }
    }
}
