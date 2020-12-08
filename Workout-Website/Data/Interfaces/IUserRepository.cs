using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workout_Website.Models;

namespace Workout_Website.Data.Interfaces
{
    interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Get user by email
        /// </summary>
        /// <param name="email">Email address</param>
        /// <returns>User or null</returns>
        Task<User> Get(string email);

        /// <summary>
        /// Check if user exist
        /// </summary>
        /// <param name="username">User name</param>
        /// <returns>True if exist, false if not</returns>
        Task<bool> IsExist(string username);

        /// <summary>
        /// Check if user exist
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>True if exist, false if not</returns>
        Task<bool> IsExist(int id);

        /// <summary>
        /// Change user password
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="newPassword">New password</param>
        /// <returns>User with new password hash and salt</returns>
        User ChangePassword(User user, string newPassword);

        /// <summary>
        /// Recovery password
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="returnUrl">Return URL</param>
        /// <returns>URL for changing password (returnUrl/token)</returns>
        string RecoveryPassword(User user, string returnUrl);
    }
}
