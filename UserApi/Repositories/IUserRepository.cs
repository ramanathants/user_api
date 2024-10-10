// Repositories/IUserRepository.cs
using UserApi.Models;

namespace UserApi.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int id);
        Task<bool> UserExists(int id);
    }
}