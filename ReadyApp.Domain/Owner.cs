﻿using ReadyApp.Domain.inheritances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Owner : BusinessMap
    {
        public int OwnerId { get; private set; }
        public decimal Ownerhship { get; set; }

        // Foirgn Keys

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
