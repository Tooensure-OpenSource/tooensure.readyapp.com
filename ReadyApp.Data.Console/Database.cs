using ReadyApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Console
{
    internal static class Database
    {
        private static readonly DataContext _dataContext = new DataContext();

        /// <summary>
        /// 1. Ef Core will read provider and connection string to database
        /// 2. Searches database to see if exist
        /// 3. If database doesn't exist, ef core will create on the fly
        /// </summary>
        public static void Init()
        {
            _dataContext.Database.EnsureCreated();
        }

        public static void AddUser(List<User> users)
        {
            foreach (var user in users)
            {
                _dataContext.Users.Add(user);
            }
            _dataContext.SaveChanges();
        }

        public static void GetUsers(string text)
        {
            var users = _dataContext.Users.ToList();
            System.Console.WriteLine($"{text}: User count is {users.Count()}");
            foreach (var user in users)
            {
                System.Console.WriteLine($"id: {user.UserId}, username: {user.Username}, email: {user.Email}, password: {user.Password}");
            }
        }
        public static bool UserExist(User user)
        {
            var users = _dataContext.Users.ToList();

            return users.Where(
                u => u.Email == user.Email || u.Username == user.Username
                &&
                u.Password == user.Password).Any();
        }
        public static User GetUser(User user)
        {
            var users = _dataContext.Users.ToList();

            return users.Find(
            u => u.Email == user.Email || u.Username == user.Username
            &&
            u.Password == user.Password);
            
        }
        //public static void GetCustomers(string text)
        //{
        //    var customers = _dataContext.Customer.ToList();
        //    System.Console.WriteLine($"{text}: User count is {customers.Count()}");
        //    foreach (var customer in customers)
        //    {
        //        System.Console.WriteLine($"id: {customer.CustomerId}, userId: {customer.UserId}");
        //    }
        //}
    }
}
