using System.ComponentModel.DataAnnotations;

namespace ReadyApp.Api.Models
{
    public class BusinessRegisterDto
    {
        [Required] public string Name { get; set; }
        [Required] public string Username { get; set; }
    }
}
