using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Shared.UserDto
{
    public class UserLogin
    {
        public string Username { get; set; }
        [Required, EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
