
using eBooks.Data;
using System.Collections.Generic;

namespace eBooks.Service
{
    public interface IAuthorsService
    {
        void AddAuthor(Author ItemToAdd);

        List<Author> GetAuthor();

        Author GetAuthorById(int id);

        void EditAuthor(Author author);

        void DeleteAuthor(int id);
    }
}
