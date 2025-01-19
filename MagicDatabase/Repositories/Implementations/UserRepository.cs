using MagicCardsAPI.Data;
using MagicDatabase.Models;
using MagicDatabase.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabase.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly MagicCardsContext _context;

        public UserRepository(MagicCardsContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}
