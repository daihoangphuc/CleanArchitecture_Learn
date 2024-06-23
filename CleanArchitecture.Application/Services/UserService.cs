using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Interfaces;

namespace CleanArchitecture.Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> GetUserByIdAsync(string id)
        {
            return _userRepository.GetUserByIdAsync(id);
        }

        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return _userRepository.GetAllUsersAsync();
        }

        public Task AddUserAsync(User user)
        {
            return _userRepository.AddUserAsync(user);
        }

        public Task UpdateUserAsync(User user)
        {
            return _userRepository.UpdateUserAsync(user);
        }

        public Task DeleteUserAsync(string id)
        {
            return _userRepository.DeleteUserAsync(id);
        }
    }
}
