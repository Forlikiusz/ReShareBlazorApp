using Microsoft.AspNetCore.Identity;
using ReShareBlazorApp.Api.Date;
using ReShareBlazorApp.Api.DTOs;
using ReShareBlazorApp.Api.Interfaces.Services;

namespace ReShareBlazorApp.Api.Services
{
    public class AuthService : IAuthService
    {
    private readonly UserManager<User> _userManager;
        public AuthService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<RegisterResponse?> RegisterAsync(RegisterRequest request)
        {
            var user = new User
            {
                UserName = request.UserName,
                Email = request.Email,
                CreatedAt = DateTime.Now,
                IsActive = true
            };
            var result = await _userManager.CreateAsync(user, request.Password);

            if(!result.Succeeded)
            {
                return null;
            }
            return new RegisterResponse
            {
                Message = "Konto zostało pomyślnie utworzone."
            };
        }
    }
}
