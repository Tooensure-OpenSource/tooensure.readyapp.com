using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public List<Business> FavoriteBusinesses { get; set; }
        public int UserId { get; set; }
        public Customer()
        {
            FavoriteBusinesses = new List<Business>();
        }
    }
}
