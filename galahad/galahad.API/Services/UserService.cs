using galahad.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace galahad.API.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IGalahadDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UserCollectionName);
        }

        public User Get(string id) =>
            _users.Find<User>(ev => ev.Id == id).FirstOrDefault();
    }
}
