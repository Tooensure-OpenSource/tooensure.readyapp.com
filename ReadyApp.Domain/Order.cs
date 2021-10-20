using ReadyApp.Domain.Entity;
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
        public bool IsReady { get; set; }

        public List<OrderItem>? OrderItems { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid BusinessId { get; set; }
        public Business? Business { get; set; }


    }
}
