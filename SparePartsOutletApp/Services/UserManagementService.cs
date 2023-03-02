using BCrypt.Net;
using SparePartsOutletApp.Models.ApiRequests.UserManagement;
using SparePartsOutletApp.Models.ApiResponse.UserManagement;
using SparePartsOutletApp.Services._Interfaces;
using SparePartsOutletApp.Services.Repositories._Interfaces;

namespace SparePartsOutletApp.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly IUserRepository _userRepo;
        private readonly ITokenService _tokenService;

        public UserManagementService(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepo = userRepository;
            _tokenService = tokenService;
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, hashType: BCrypt.Net.HashType.SHA384);
        }

        public bool VerifyPassword(string password, string passwordHashed)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, passwordHashed, hashType: HashType.SHA384);
        }

        public UserLoginResponse Login(UserLoginRequest userLoginRequest)
        {
            var user = _userRepo.GetUserByName(userLoginRequest.UserName);

            if (user != null)
            {
                if (VerifyPassword(userLoginRequest.Password, user.PasswordHashed))
                {
                    var token = _tokenService.GenerateLoginToken(user);

                    var response = new UserLoginResponse()
                    {
                        AuthenticationToken = _tokenService.GenerateLoginToken(user)
                    };
                    return response;
                }
            }

            return new UserLoginResponse();

        }
    }
}
