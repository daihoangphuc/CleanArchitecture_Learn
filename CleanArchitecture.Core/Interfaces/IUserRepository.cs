using CleanArchitecture.Core.Entities;
using System.Collections.Generic;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(string id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task AddUserAsync(User user);

        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(string id);
    }
}
