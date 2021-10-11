using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReadyApp.Data;
using ReadyApp.Data.Services;
using ReadyApp.Domain;

namespace ReadyApp.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _datacontext;

        public UserRepository(DataContext datacontext)
        {
            _datacontext = datacontext ?? throw new ArgumentNullException(nameof(datacontext));
        }

        public IEnumerable<User> GetUsers()
        {
            return _datacontext.Users.ToList();
        }
    }
}
