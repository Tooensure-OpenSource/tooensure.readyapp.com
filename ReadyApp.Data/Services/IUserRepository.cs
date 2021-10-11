using ReadyApp.Domain;
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
    }
}
