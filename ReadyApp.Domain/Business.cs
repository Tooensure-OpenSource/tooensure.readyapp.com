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
        public List<User> Users { get; set; }

        // Constructor instances
        public Business() {
            Users = new List<User>();
        }
        /// <summary>
        /// Create a instance of a business object.
        /// </summary>
        /// <param name="user">Sets user and passes that user id into forign user id</param>
        public Business(List<User> users)
        {
            Users = users;
        }
        /// <summary>
        /// Create a instance of a business object.
        /// </summary>
        /// <param name="user">Sets user and passes that user id into forign user id</param>
        /// <param name="name">Sets name of business</param>
        /// <param name="description">Sets description of business</param>
    }
}
