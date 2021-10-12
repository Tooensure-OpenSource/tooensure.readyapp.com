using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain.inheritances
{
    public abstract class UserMap
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
