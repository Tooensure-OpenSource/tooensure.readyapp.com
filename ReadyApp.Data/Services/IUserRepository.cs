using ReadyApp.Domain;
using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Services
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(Guid userId);
        bool UserExist(Guid userId);
    }
}
