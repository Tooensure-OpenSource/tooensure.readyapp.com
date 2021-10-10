using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public User? User { get; set; }

        public int BusinessId { get; set; }
        public Business? Business { get; set; }
    }
}
