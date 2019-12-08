using galahad.Models;
using System.Threading.Tasks;

namespace galahad.API.Services
{
    public interface IOwnerApiClient
    {
        Task<Event> CreateEvent();
        Task<Event> ModifyEvent(Event newEvent);
        Task<Group> CreateGroup();
        Task<Group> ModifyGroup(Group group);
    }
}
