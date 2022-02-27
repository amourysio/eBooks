using eBooks.Data;
using System.Collections.Generic;

namespace eBooks.Service
{
    public interface IPublishersService
    {
        void AddPublisher(Publisher ItemToAdd);

        List<Publisher> GetPublisher();

        Publisher GetPublisherById(int id);

        void EditPublisher(Publisher publisher);

        void DeletePublisher(int id);
    }
}