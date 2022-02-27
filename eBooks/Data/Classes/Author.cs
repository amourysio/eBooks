using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eBooks.Data
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        
        
        public List<Book> Books { get; set; }

    }
}
