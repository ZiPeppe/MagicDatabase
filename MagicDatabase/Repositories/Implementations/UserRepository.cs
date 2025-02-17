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
        public async Task SaveRefreshTokenAsync(RefreshToken refreshToken)
        {
            _context.RefreshTokens.Add(refreshToken);
            await _context.SaveChangesAsync();
        }
        public async Task<RefreshToken> GetRefreshTokenAsync(string token)
        {
            var refreshToken = await _context.RefreshTokens.FirstOrDefaultAsync(rt => rt.Token == token);
            // Se il token non esiste, ritorna null, che è già il comportamento normale di FirstOrDefaultAsync.
            // Non c'è bisogno di lanciare eccezioni qui, va bene mantenere il comportamento di default.
            return refreshToken;
        }
        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
        }
        public async Task UpdateRefreshTokenAsync(RefreshToken refreshToken)
        {
            _context.RefreshTokens.Update(refreshToken);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> DeleteRefreshTokenAsync(string refreshToken)
        {
            var token = await _context.RefreshTokens.FirstOrDefaultAsync(rt => rt.Token == refreshToken);

            if (token == null)
            {
                return false; // Non trovato, restituisci false
            }

            _context.RefreshTokens.Remove(token);
            var result = await _context.SaveChangesAsync();

            return result > 0; // Restituisce true se è stato eliminato con successo
        }
    }
}
