using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workout_Website.Models;

namespace Workout_Website.Data.Interfaces
{
    interface IAuthRepository
    {
        /// <summary>
        /// Login user
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>If logged in successfully returns user, else null</returns>
        Task<User> Login(string username, string password);

        /// <summary>
        /// Register new user
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="password">Password</param>
        /// <returns>New user</returns>
        Task<User> Register(User user, string password);
    }
}
