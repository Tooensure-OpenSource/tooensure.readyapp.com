using System.ComponentModel.DataAnnotations;

namespace ReadyApp.Api.Models
{
    /// <summary>
    /// In order to regiter a user requires are set, please set all required fields
    /// </summary>
    public class UserRegisterDto
    {
        [Required] public string Username { get; set; }
        [Required] public string EmailAddress { get; set; }
        [Required] public string Password {  get; set; }           
       
    }
}
