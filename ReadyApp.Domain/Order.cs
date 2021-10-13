using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Order
    {
        public Guid OrderId { get; private set; }
        public DateTime dateTime { get; private set; }
        public bool isReady { get; set; }
        private List<OrderItem>? OrderItems { get; set; }
        private Guid CustomerId { get; set; }
        private Customer Customer { get; set; }



        /// <summary>
        /// Create Order instance and also create a instance of order items
        /// </summary>
        public Order() => OrderItems = new List<OrderItem>();
        //public Order(User user) => UserId = user.UserId;
        public Order(Customer customer) => CustomerId = customer.CustomerId;
    }
}
