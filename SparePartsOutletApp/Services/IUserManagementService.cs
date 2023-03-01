namespace SparePartsOutletApp.Services
{
    public interface IUserManagementService
    {
        string HashPassword(string password);
    }
}