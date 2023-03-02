using SparePartsOutletApp.Context;
using SparePartsOutletApp.Models.Entities;
using SparePartsOutletApp.Services.Repositories._Interfaces;

namespace SparePartsOutletApp.Services.Repositories
{
    public class UserRepository :IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User GetUserByName(string userName)
        {
            return _context.Users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
