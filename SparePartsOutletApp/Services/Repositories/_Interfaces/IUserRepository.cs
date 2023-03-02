using SparePartsOutletApp.Models.Entities;

namespace SparePartsOutletApp.Services.Repositories._Interfaces
{
    public interface IUserRepository
    {
        User GetUserByName(string userName);

    }
}
