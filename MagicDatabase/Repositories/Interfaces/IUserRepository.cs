using MagicDatabase.Models;

namespace MagicDatabase.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
    }
}
