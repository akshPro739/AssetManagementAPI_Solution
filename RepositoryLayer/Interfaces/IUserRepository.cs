using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace RepositoryLayer.Interfaces
{





    public interface IUserRepository
    {
        // User Registration
        User RegisterUser(User user);

        // User Login
        User? ValidateUser(string userName, string password);

        // Get All Users
        IEnumerable<User> GetAllUsers();

        // Get User By Id
        User? GetUserById(int userId);

        // Update User
        User UpdateUser(User user);

        // Delete User
        bool DeleteUser(int userId);

        // Search User
        IEnumerable<User> SearchUsers(string keyword);
    }


}
