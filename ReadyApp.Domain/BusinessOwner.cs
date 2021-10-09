using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class BusinessOwner
    {
        public int BusinessOwnerId { get; set; }
        public decimal Ownership { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int BusinesId { get; set; }
        public Business Business { get; set; }
    }
}
