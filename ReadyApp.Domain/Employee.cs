using ReadyApp.Domain.Entity;
using ReadyApp.Domain.inheritances;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    /// <summary>
    /// In a employee logic: new Business(new Employee(new User)) will map owner current user around the business
    /// </summary>
    public class Employee : BusinessMap
    {
        public Guid EmployeeId { get; private set; }



        /// <summary>
        /// Initulize Business Constructor
        /// </summary>
        public Employee() => Console.WriteLine("Initulize Business");
        //public Employee(User user) => UserId = user.UserId;

        //override User GetUser()
        //{
        // return User
        //}

        //override GetBusiness()
        //{

        //}
    }
}
