using Microsoft.AspNetCore.Identity;

namespace NZWalk.Api.Models.DTO
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
