using galahad.API.Services;
using galahad.Models;
using System;
using System.Threading.Tasks;

namespace galahad.API.Client
{
    public class OwnerApiClient : AuthorisedClientBase, IOwnerApiClient
    {
        public OwnerApiClient(string accessToken) : base(accessToken)
        {

        }

        public Task<Event> CreateEvent()
        {
            throw new NotImplementedException();
        }

        public Task<Group> CreateGroup()
        {
            throw new NotImplementedException();
        }

        public Task<Event> ModifyEvent(Event newEvent)
        {
            throw new NotImplementedException();
        }

        public Task<Group> ModifyGroup(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
