using galahad.API.Services;
using galahad.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace galahad.API.Client
{
    public class UserApiClient : AuthorisedClientBase, IUserApiClient
    {
        public UserApiClient(string accessToken) : base(accessToken)
        {
            
        }

        public Task<Event> GetEventById(string eventId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetEventsForGroup(string groupId)
        {
            throw new NotImplementedException();
        }

        public Task<Group> GetGroupById(string groupId)
        {
            throw new NotImplementedException();
        }
    }
}
