using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workout_Website.Data.Interfaces
{
    interface IPasswordRepository
    {
        /// <summary>
        /// Verify password hashes
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="passwordHash">Password hash</param>
        /// <param name="passwordSalt">Password salt</param>
        /// <returns>True if hashes are correct, else false</returns>
        bool VerifyHash(string password, byte[] passwordHash, byte[] passwordSalt);

        /// <summary>
        /// Create password hashes and returns as a output parameter
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="passwordHash">Empty password hash</param>
        /// <param name="passwordSalt">Empty password salt</param>
        void CreateHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
    }
}
