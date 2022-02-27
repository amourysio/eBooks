using eBooks.Data;
using System.Collections.Generic;
using System.Linq;

namespace eBooks.Service
{
    public class AuthorsService : IAuthorsService
    {
        private readonly ApplicationDbContext db;

        public AuthorsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddAuthor(Author ItemToAdd)
        {
            db.Authors.Add(ItemToAdd);
            db.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            var objID = this.GetAuthorById(id);
            this.db.Authors.Remove(objID);
            db.SaveChanges();
        }

        public void EditAuthor(Author author)
        {
            var NewAuthor = this.GetAuthorById(author.Id);

            NewAuthor.FullName = author.FullName;
            NewAuthor.ProfilePictureURL = author.ProfilePictureURL;
            NewAuthor.Bio = author.Bio;
        }

        public List<Author> GetAuthor() => db.Authors.ToList();

        public Author GetAuthorById(int id) => this.db.Authors.FirstOrDefault(x => x.Id == id);

    }
}