using eBooks.Data;
using System.Collections.Generic;
using System.Linq;

namespace eBooks.Service
{
    public class PublishersService : IPublishersService
    {
        private readonly ApplicationDbContext db;

        public PublishersService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddPublisher(Publisher ItemToAdd)
        {
            db.Publishers.Add(ItemToAdd);
            db.SaveChanges();
        }

        public void DeletePublisher(int id)
        {
            var objID = this.GetPublisherById(id);
            this.db.Publishers.Remove(objID);
            db.SaveChanges();
        }

        public void EditPublisher(Publisher publisher)
        {
            var NewPublisher = this.GetPublisherById(publisher.Id);

            NewPublisher.Name = publisher.Name;
            NewPublisher.Logo = publisher.Logo;
        }

        public List<Publisher> GetPublisher() => db.Publishers.ToList();


        public Publisher GetPublisherById(int id) => this.db.Publishers.FirstOrDefault(x => x.Id == id);

    }
}
