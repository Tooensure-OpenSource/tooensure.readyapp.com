using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class OrderItem
    {
        [Key]
        public Guid OrderItemId { get; private  set; }

        public int Quantity { get; set; } = 1;
        public List<Order>? Orders { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// When creating a instance of order a order item instance can create a new referance 
        /// </summary>
        public OrderItem()
        {
            Orders = new List<Order>();
        }
    }
}
