using SparePartsOutletApp.Models.Entities;

namespace SparePartsOutletApp.Services._Interfaces
{
    public interface ITokenService
    {
        string GenerateLoginToken(User user);
    }
}
