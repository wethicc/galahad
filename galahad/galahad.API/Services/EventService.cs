using galahad.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace galahad.API.Services
{
    public class EventService
    {
        private readonly IMongoCollection<Event> _events;

        public EventService(IGalahadDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _events = database.GetCollection<Event>(settings.EventCollectionName);
        }

        public Event Get(string id) =>
            _events.Find<Event>(ev => ev.Id == id).FirstOrDefault();

        public Event GetMany(string[] ids) =>
            _events.Find<Event>(ev => ids.Contains(ev.Id)).FirstOrDefault();
    }
}
