using GloboCrypto.Models.Authentication;
using GloboCrypto.WebAPI.Services.Models;

namespace GloboCrypto.WebAPI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<AuthTokenResponse> Authenticate(string id);
        Task<IEnumerable<RegisteredInstance>> GetRegisteredInstances();
    }
}
