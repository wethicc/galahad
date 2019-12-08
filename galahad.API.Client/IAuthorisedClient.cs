using System.Threading.Tasks;

namespace galahad.API.Client
{
    public interface IAuthorisedClient
    {
        Task<bool> Authorised(string modelId);
    }
}
