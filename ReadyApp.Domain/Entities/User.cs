using ReadyApp.Domain.inheritances;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ReadyApp.Domain.Entity
{

    /// <summary>
    /// A user inherts from person. A user is a person.
    /// All user are identified first. 
    /// A persn is identified by things like SSN, ID, etc,
    /// A user is identifed by things like passwords, ids, etc.
    /// </summary>
    public class User : Person
    {
        [Key]
        public Guid UserId { get; private set; }

        [Required, MaxLength(20, ErrorMessage = "Username max charater length is 20")] 
        public string? Username { get; set; }

        [Required, EmailAddress(ErrorMessage = "Not a valid email address")] 
        public string? Email { get; set; }

        [Required] 
        public string? Password { get; set; }

        public List<Order> Orders { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }
    }
}