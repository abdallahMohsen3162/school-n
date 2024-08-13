using Microsoft.AspNetCore.Identity;
using School.Models;
using BusinessLogicLayer.ModelViews;
using System.Security.Claims;
using DataAccessLayer.Models;
using BusinessLogicLayer.ModelViews;


namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserAsync(ClaimsPrincipal user);
        Task<ApplicationUser> GetUserByEmailAsync(string email);
        List<ApplicationUser> GetAllUsers();
        Task<IdentityResult> RegisterUser(RegisterViewModel model);
        Task<IdentityResult> DeleteUserAsync(ApplicationUser user);
        Task<bool> CheckPasswordAsync(ApplicationUser user, string password);
    }
}
