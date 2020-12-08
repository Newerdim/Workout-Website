using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workout_Website.Models;

namespace Workout_Website.Data.Interfaces
{
    interface IJwtTokenRepository
    {
        /// <summary>
        /// Get id from token
        /// </summary>
        /// <param name="token">JWT token</param>
        /// <returns>User id</returns>
        int GetId(string token);

        /// <summary>
        /// Check if token is valid
        /// </summary>
        /// <param name="token">JWT token</param>
        /// <returns>True if token is valid, else false</returns>
        bool IsValid(string token);

        /// <summary>
        /// Generate JWT token
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="secret">Secret for hashing</param>
        /// <param name="expireIn">How long will the token be valid</param>
        /// <returns>JWT token</returns>
        string Generate(User user, string secret, TimeSpan expireIn);

        /// <summary>
        /// Generate JWT token with password hash and secret
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="secret">Secret for hashing</param>
        /// <param name="expireIn">How long will the token be valid</param>
        /// <returns>JWT token</returns>
        string GenerateWithPasswordHash(User user, string secret, TimeSpan expireIn);
    }
}
