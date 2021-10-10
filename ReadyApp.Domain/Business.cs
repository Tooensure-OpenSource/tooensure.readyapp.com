using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public class Business
    {
        [Key]
        public int BusinessId { get; private set; }
        [Required]
        public string Name {  get; private set; }
        [Required]
        public string Username { get; private set; }
        public string Description {  get; private set; }
        public string Type {  get; private set; }
        public List<Owner> Owners { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        // Constructor instances
        public Business() {
            Products = new List<Product>();
            Orders = new List<Order>();
            Owners = new List<Owner>();
            Employees = new List<Employee>();
        }
        /// <summary>
        /// Create a instance of a business object and add owners
        /// </summary>
        /// <param name="owners">Sets user and passes that owners id into forign owners id</param>
        public Business(List<Owner> owners)
        {
            Owners = owners;
        }
        /// <summary>
        /// Create a instance of a business object.
        /// </summary>
        /// <param name="user">Sets user and passes that user id into forign user id</param>
        /// <param name="name">Sets name of business</param>
        /// <param name="description">Sets description of business</param>
    }
}
