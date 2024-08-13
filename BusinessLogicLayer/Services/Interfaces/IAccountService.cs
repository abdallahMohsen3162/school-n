
using BusinessLogicLayer.ModelViews;
using DataAccessLayer.Models;


namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IAccountService : IAuthService, IUserService
    {
        ProfileViewModel MapUserToProfileViewModel(ApplicationUser user);
    }

}
