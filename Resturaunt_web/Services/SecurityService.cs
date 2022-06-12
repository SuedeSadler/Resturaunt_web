using Resturaunt_web.Models;
using Resturaunt_web.Services.Data;

namespace Resturaunt_web.Services
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(Login user)
        {
            return daoService.FindByUser(user);
        }
    }
}
