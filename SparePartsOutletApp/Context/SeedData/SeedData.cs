using SparePartsOutletApp.Context.SeedData._Interfaces;
using SparePartsOutletApp.Models.Entities;
using SparePartsOutletApp.Services._Interfaces;

namespace SparePartsOutletApp.Context.SeedData
{
    public class SeedData : ISeedData
    {
        private readonly IConfiguration _configuration;

        public SeedData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User SeedAdmin()
        {
            var admin = new User()
            {
                Id = _configuration.GetValue<int>("UserAdmin:Id"),
                UserName = _configuration.GetValue<string>("UserAdmin:UserName"),
                UserEmail = _configuration.GetValue<string>("UserAdmin:UserEmail"),
                PasswordHashed = BCrypt
                        .Net
                        .BCrypt
                        .EnhancedHashPassword(_configuration.GetValue<string>("UserAdmin:Password"), hashType: BCrypt.Net.HashType.SHA384),
                RoleName = _configuration.GetValue<string>("UserAdmin:RoleName"),
            };

            return admin;
        }
    }
}
