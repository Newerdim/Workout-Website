using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workout_Website.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IAuthRepository Auth { get; }
        IPasswordRepository Password { get; }
        IUserRepository User { get; }

        Task SaveAsync();
        Task DisposeAsync();
    }
}
