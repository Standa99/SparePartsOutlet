using SparePartsOutletApp.Models.ApiRequests.UserManagement;
using SparePartsOutletApp.Models.ApiResponse.UserManagement;

namespace SparePartsOutletApp.Services._Interfaces
{
    public interface IUserManagementService
    {
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHashed);
        UserLoginResponse Login(UserLoginRequest userLoginRequest);
    }
}