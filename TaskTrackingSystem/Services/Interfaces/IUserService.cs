
using TaskTrackingSystem.Models;

namespace TaskTrackingSystem.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string username, string password);
    }
}
