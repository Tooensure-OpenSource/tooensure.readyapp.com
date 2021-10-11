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
        private int UserId { get; set; }
        private User? User { get; set; }

        public int BusinessId { get; set; }
        public Business? Business { get; set; }
        public Owner()
        {

        }

        /// <summary>
        /// Something just interests by writing code like new Business(new Owner(new User())).
        /// Mapping the user this way may be intelligence
        /// </summary>
        /// <param name="user"></param>
        public Owner(User user) => UserId = user.UserId;
    }
}
