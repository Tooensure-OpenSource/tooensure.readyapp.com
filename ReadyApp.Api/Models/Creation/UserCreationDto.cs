using System.ComponentModel.DataAnnotations;

namespace ReadyApp.Api.Models.Creation
{
    public class UserCreationDto
    {
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string Username { get; set; }
        [Required] public string EmailAddress { get; set; }
        [Required] public string Password { get; set; }
    }
}
