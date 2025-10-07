using MultiShop.WebUI.Services.Interfaces;
using System.Security.Claims;

namespace MultiShop.WebUI.Services.Concrete
{
    public class LoginService : ILoginService
    {
        private readonly IHttpContextAccessor contextAccessor;

        public LoginService(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public string GetUserId => contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}
