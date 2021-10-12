using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReadyApp.Data;
using ReadyApp.Data.Services;
using ReadyApp.Domain.Entity;

namespace ReadyApp.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _datacontext;

        public UserRepository(DataContext datacontext)
        {
            _datacontext = datacontext ?? throw new ArgumentNullException(nameof(datacontext));
        }

        public User GetUser(Guid userId)
        {
            return _datacontext.Users.Where(u => u.UserId == userId).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return _datacontext.Users.ToList();
        }

        public bool UserExist(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            return _datacontext.Users.Any(u => u.UserId == userId);
        }
    }
}
