using ReadyApp.Domain;
using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Services
{
    /// <summary>
    /// Modern design patteren using interfaces to implement data access, Data Transfer object structure prepration
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Get users from database (only used for experiment/debug)
        /// But if have to need be.
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetUsers();
        /// <summary>
        /// Get a user in data store with id of param
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        User GetUser(Guid userId);
        /// <summary>
        /// Many cases we want to know if a user is in fact a actual active user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool UserExist(Guid userId);
        bool UserExists(User user);
        bool UserExistByUsername(User user);
        void CreateUser(User user);
        void Save();
        //void UpdateUser(Guid userId, User user);
    }
}
