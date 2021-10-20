using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain.Entity
{
    public class Business
    {
        [Key]
        public Guid BusinessId { get; private set; }

        public string Name { get; set; }

        [Required]
        public string? Username { get; private set; }
        public string? Description {  get; private set; }
        public string? Type {  get; private set; }

        public DateTime? CreatedDate { get; set; }

        [Required]
        public List<Owner>? Owners { get; set; }
        public List<Employee>? Employees { get; set; }
        public List<Product>? Products { get; set; }
        public List<Order>? Orders { get; set; }

        public Business()
        {
            Owners = new List<Owner>();
            Employees = new List<Employee>();
            Products = new List<Product>();
            Orders = new List<Order>();
        }

    }
}
