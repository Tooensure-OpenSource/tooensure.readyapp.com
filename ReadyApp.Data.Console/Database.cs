using ReadyApp.Domain;
using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Console
{
    public static class Database
    {
        private static readonly DataContext _dataContext = new Object();

        public static void AddUser(User user) => _dataContext.Users.Add(user);
        public static void AddBusiness(Business business) => _dataContext.Businesses.Add(business);
        public static void AddOwner(Owner owner) => _dataContext.Owners.Add(owner);
    }
}
