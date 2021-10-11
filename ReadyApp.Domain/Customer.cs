using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    /// new Business(new Customer(new Order(newOrderItem [](new product(new ProductItem[]()))))'
    /// new Business(new Customer(new Order(new User()))'
    public class Customer
    {
        // new Business(new Customer(new (new User())))

        public int CustomerId { get; private set; }

        private int UserId { get; set; }
        private User User { get; set; }

        private List<Business> Businesses { get; set; }
        public List<Order>? Orders { get; set; }


        public Customer() => Orders = new List<Order>();
        public Customer(User user) => UserId = user.UserId;
    }

}
