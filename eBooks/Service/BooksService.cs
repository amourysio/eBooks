using eBooks.Data;
using System.Collections.Generic;
using System.Linq;

namespace eBooks.Service
{
    public class BooksService : IBooksService
    {
        private readonly ApplicationDbContext db;

        public BooksService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddBook(Book ItemToAdd)
        {
            db.Books.Add(ItemToAdd);
            db.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var objID = this.GetBookById(id);
            this.db.Books.Remove(objID);
            db.SaveChanges();
        }

        public void EditBook(Book book)
        {
            var Newbook = this.GetBookById(book.Id);

            Newbook.BookName = book.BookName;
            Newbook.BookPictureURL = book.BookPictureURL;
            Newbook.Date = book.Date;
        }

        public List<Book> GetBook() => db.Books.ToList();
        

        public Book GetBookById(int id) =>  this.db.Books.FirstOrDefault(x => x.Id == id);
        
    }
}
