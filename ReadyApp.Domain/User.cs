using System.ComponentModel.DataAnnotations;

namespace ReadyApp.Domain
{
    public class User
    {
        [Key]
        public int UserId { get; private set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public List<Business> Businesses { get; set; }

        // Constructor instances
        public User() { }
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

        /// <summary>
        /// Only used for testing
        /// Implemented in project : ReadyApp.Data.Console
        /// </summary>
        public void SetId(int id)
        {
            UserId = id;
        }
    }
}