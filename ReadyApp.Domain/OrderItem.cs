using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class OrderItem
    {
        public int OrderItemId { get; private  set; }
        public int Quantity { get; set; }
        public List<Order>? OrderReferances { get; set; }
        /// <summary>
        /// When creating a instance of order a order item instance can create a new referance 
        /// </summary>
        public OrderItem()
        {
            OrderReferances = new List<Order>();
        }
    }
}
