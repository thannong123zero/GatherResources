using jwtWebAPI.Models;
using System.Security.Claims;

namespace jwtWebAPI.Services
{
    public interface IJwtService
    {
        string GenerateAccessToken(UserModel model);
        string GenerateRefreshToken();
        string RenewToken(string expiredToken);
        //ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
