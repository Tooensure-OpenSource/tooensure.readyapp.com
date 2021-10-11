using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Domain
{
    public enum occupation
    {
        Employee = 1,
        Owner = 2,
    }
    public class Business
    {
        [Key]
        public int BusinessId { get; private set; }
        [Required]
        public string? Name {  get; private set; }
        [Required]
        public string? Username { get; private set; }
        public string? Description {  get; private set; }
        public string? Type {  get; private set; }
        [Required]
        public List<Owner>? Owners { get; set; }
        public List<Employee>? Employees { get; set; }
        public List<Product>? Products { get; set; }
        public List<Customer> Customers { get; set; }
        // Constructor instances
        public Business() {
            Products = new List<Product>();
            Owners = new List<Owner>();
            Employees = new List<Employee>();
            Customers = new List<Customer>();
        }
        /// <summary>
        /// Create a instance of a business object and add owners
        /// </summary>
        /// <param name="owners">Sets user and passes that owners id into forign owners id</param>
        public Business(Owner owner) => Owners?.Add(owner);
        public Business(Employee employee) => Employees?.Add(employee);
        public Business(Customer customers) => Customers?.Add(customers);

    }
}
