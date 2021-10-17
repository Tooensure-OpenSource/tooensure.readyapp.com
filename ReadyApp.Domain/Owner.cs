using ReadyApp.Domain.Entity;
using ReadyApp.Domain.inheritances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Owner : BusinessMap
    {
        public Guid OwnerId { get; private set; }
        public decimal Ownerhship { get; set; }
        public Owner()
        {
                
        }
        public Owner(Guid userId, Guid businessId)
        {
                UserId = userId;
                BusinessId = businessId;
        }
        // Foirgn Keys



        /// <summary>
        /// Something just interests by writing code like new Business(new Owner(new User())).
        /// Mapping the user this way may be intelligence
        /// </summary>
        /// <param name="user"></param>
       //public Owner(User user) => UserId = user.UserId;
    }
}
