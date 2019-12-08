using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace galahad.API.Client
{
    public class AuthorisedClientBase : IAuthorisedClient
    {
        protected string _accessToken;
        public AuthorisedClientBase(string accessToken)
        {
            _accessToken = accessToken
                ?? throw new ArgumentNullException(nameof(accessToken));
        }

        public Task<bool> Authorised(string modelId)
        {
            throw new NotImplementedException();
        }
    }
}
