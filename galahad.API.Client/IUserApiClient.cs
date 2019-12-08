using galahad.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace galahad.API.Services
{
    public interface IUserApiClient
    {
        Task<Event> GetEventById(string eventId);
        Task<IEnumerable<Event>> GetEventsForGroup(string groupId);
        Task<Group> GetGroupById(string groupId);
    }
}
