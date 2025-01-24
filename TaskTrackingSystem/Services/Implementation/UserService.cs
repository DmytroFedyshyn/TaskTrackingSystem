using Microsoft.EntityFrameworkCore;
using TaskTrackingSystem.Data;
using TaskTrackingSystem.Models;
using TaskTrackingSystem.Services.Interfaces;

namespace TaskTrackingSystem.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }

        async Task<User> IUserService.AuthenticateAsync(string username, string password)
        {
            var user = await AuthenticateAsync(username, password);
            if (user == null)
            {
                throw new InvalidOperationException("User not found");
            }
            return user;
        }
    }
}
