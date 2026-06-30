using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using global::ServiceLayer.Interfaces;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;


namespace ServiceLayer.Implementations
{
    
   
        public class UserService : IUserService
        {
            private readonly IUserRepository _userRepository;
            private readonly ILogger<UserService> _logger;

            // Dependency Injection
            public UserService(IUserRepository userRepository, ILogger<UserService> logger)
            {
                _userRepository = userRepository;
                _logger = logger;
            }

            // Register User
            public User RegisterUser(User user)
            {
                _logger.LogInformation("Registering user: {UserName}", user.UserName);
                return _userRepository.RegisterUser(user);
            }

            // Validate User Login
            public User? ValidateUser(string userName, string password)
            {
                var user = _userRepository.ValidateUser(userName, password);

                if (user == null)
                {
                    _logger.LogWarning("Invalid login attempt for user: {UserName}", userName);
                    return null;
                }

                _logger.LogInformation("User logged in successfully: {UserName}", userName);
                return user;
            }

            // Get All Users
            public IEnumerable<User> GetAllUsers()
            {
                return _userRepository.GetAllUsers();
            }

            // Get User By Id
            public User? GetUserById(int userId)
            {
                return _userRepository.GetUserById(userId);
            }

            // Update User
            public User UpdateUser(User user)
            {
                _logger.LogInformation("Updating user: {UserId}", user.UserId);
                return _userRepository.UpdateUser(user);
            }

            // Delete User
            public bool DeleteUser(int userId)
            {
                _logger.LogInformation("Deleting user: {UserId}", userId);
                return _userRepository.DeleteUser(userId);
            }

            // Search Users
            public IEnumerable<User> SearchUsers(string keyword)
            {
                return _userRepository.SearchUsers(keyword);
            }
        }
    
}
