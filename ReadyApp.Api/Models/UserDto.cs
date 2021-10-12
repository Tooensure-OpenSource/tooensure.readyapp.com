using ReadyApp.Domain;

namespace ReadyApp.Api.Models
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string? Username { get; set; }
        public string? EmailAddress { get; set; }
        public string? Name { get; set; }
    }
}
