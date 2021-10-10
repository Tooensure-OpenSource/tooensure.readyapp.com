using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Owner
    {
        public int OwnerId { get; private set; }
        public decimal Ownerhship { get; set; }

        // Foirgn Keys
        public int UserId { get; set; }
        public User? User { get; set; }

        public int BusinessId { get; set; }
        public Business? Business { get; set; }
    }
}
