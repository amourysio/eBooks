using eBooks.Data;
using System.Collections.Generic;

namespace eBooks.Service
{
    public interface IBooksService
    {
        void AddBook(Book ItemToAdd);

        List<Book> GetBook();

        Book GetBookById(int id);

        void EditBook(Book book);

        void DeleteBook(int id);
    }
}
