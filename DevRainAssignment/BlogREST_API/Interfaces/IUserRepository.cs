using BlogREST_API.DTO;
using BlogREST_API.Models;
using BlogREST_API.Repositories;
using System.Security.Claims;

namespace BlogREST_API.Interfaces
{
    public interface IUserRepository: IDefaultActions<User>
    {
        UserAuntethicateResponse Authenticate(UserAuthenticateRequest model);
    }
}
