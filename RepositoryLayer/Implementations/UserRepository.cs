using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using global::RepositoryLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Interfaces;

namespace RepositoryLayer.Implementations
{




        public class UserRepository : IUserRepository
        {
            private readonly AssetManagementDbContext _context;

            // Dependency Injection
            public UserRepository(AssetManagementDbContext context)
            {
                _context = context;
            }

            // Register User
            public User RegisterUser(User user)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user;
            }

            // Validate User Login
            public User? ValidateUser(string userName, string password)
            {
                return _context.Users
                    .Include(u => u.Role)
                    .FirstOrDefault(u =>
                        u.UserName == userName &&
                        u.Password == password &&
                        u.IsActive == true);
            }

            // Get All Users
            public IEnumerable<User> GetAllUsers()
            {
                return _context.Users
                    .Include(u => u.Role)
                    .ToList();
            }

            // Get User By Id
            public User? GetUserById(int userId)
            {
                return _context.Users
                    .Include(u => u.Role)
                    .FirstOrDefault(u => u.UserId == userId);
            }

            // Update User
            public User UpdateUser(User user)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return user;
            }

            // Delete User
            public bool DeleteUser(int userId)
            {
                var user = _context.Users.Find(userId);

                if (user == null)
                {
                    return false;
                }

                _context.Users.Remove(user);
                _context.SaveChanges();

                return true;
            }

            // Search Users
            public IEnumerable<User> SearchUsers(string keyword)
            {
                return _context.Users
                    .Include(u => u.Role)
                    .Where(u => u.UserName.Contains(keyword))
                    .ToList();
            }
        }
    
}
