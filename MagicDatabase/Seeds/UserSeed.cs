using MagicDatabase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MagicDatabase.Seeds
{
    public static class UserSeed
    {
        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<User>();

            var adminUser = new User
            {
                UserId = 1,
                Username = "admin",
                Role = "Admin"
            };
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin123"); // Hash della password

            var regularUser = new User
            {
                UserId = 2,
                Username = "user",
                Role = "User"
            };
            regularUser.PasswordHash = passwordHasher.HashPassword(regularUser, "User123"); // Hash della password

            modelBuilder.Entity<User>().HasData(adminUser, regularUser);
        }
    }
}
