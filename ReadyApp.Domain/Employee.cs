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
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; private set; }

        public string? Name { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }



    }
}
