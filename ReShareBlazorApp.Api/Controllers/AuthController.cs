using Microsoft.AspNetCore.Mvc;
using ReShareBlazorApp.Api.Interfaces.Services;

namespace ReShareBlazorApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
    }
}
