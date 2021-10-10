using ReadyApp.Domain.inheritances;
using System.ComponentModel.DataAnnotations;


namespace ReadyApp.Domain
{
    public enum occupation
    {
        None = 0,
        Employee = 1,
        Enentrepreneur = 2,
        Owner = 3,
    }
    /// <summary>
    /// A user inherts from person. A user is a person.
    /// All user are identified first. 
    /// A persn is identified by things like SSN, ID, etc,
    /// A user is identifed by things like passwords, ids, etc.
    /// </summary>
    public class User : Person
    {
        public int UserId { get; private set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public List<Business> Businesses { get; set; }
        public List<Order> Orders { get; set; }

        // Constructor instances
        public User() { Businesses = new List<Business>(); }
        /// <summary>
        /// Create user object by using this instance
        /// </summary>
        /// <param name="username">All users must have username for auth and other purposes</param>
        /// <param name="email">All users must have email for auth and other purposes</param>
        /// <param name="password">All users must have password for auth and other purposes</param>
        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

    }
}