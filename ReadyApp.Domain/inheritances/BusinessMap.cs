using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain.inheritances
{
    public abstract class BusinessMap : UserMap
    {
        public Guid BusinessId { get; set; }
        public Business Business { get; set; }
    }
}
