namespace SparePartsOutletApp.Services
{
    public class UserManagementService : IUserManagementService
    {

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, hashType: BCrypt.Net.HashType.SHA384);
        }
    }
}
