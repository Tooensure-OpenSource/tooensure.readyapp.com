using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Order
    {
        public int OrderId { get; private set; }
        public DateTime dateTime { get; set; }
        public bool isReady { get; set; }
        public List<OrderItem>? OrderItems { get; set; }

        /// <summary>
        /// Create Order instance and also create a instance of order items
        /// </summary>
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
