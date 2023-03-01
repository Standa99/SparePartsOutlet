using SparePartsOutletApp.Models.Entities;
using SparePartsOutletApp.Services;

namespace SparePartsOutletApp.Context.SeedData
{
    public class SeedData : ISeedData
    {
        private readonly IConfiguration _configuration;
        private readonly IUserManagementService _userManagementService;

        public SeedData(
            IConfiguration configuration, 
            IUserManagementService userManagementService
            )
        {
            _configuration = configuration;
            _userManagementService = userManagementService;
        }

        public User SeedAdmin()
        {
            

            var admin = new User()
            {
                Id = _configuration.GetValue<int>("UserAdmin:Id"),
                UserName = _configuration.GetValue<string>("UserAdmin:UserName"),
                UserEmail = _configuration.GetValue<string>("UserAdmin:UserEmail"),
                PasswordHashed = _userManagementService.HashPassword(_configuration.GetValue<string>("UserAdmin:Password")),
                RoleName = _configuration.GetValue<string>("UserAdmin:RoleName"),
            };

            


            return admin;
        }
    }
}
