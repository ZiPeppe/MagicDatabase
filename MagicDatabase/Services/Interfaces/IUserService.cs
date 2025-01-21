using MagicDatabase.Models;

namespace MagicDatabase.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> AuthenticateAsync(string username, string password);
        //Task<User> GetUserByUsernameAsync(string username);
    }
}
