namespace ReadyApp.Api.Models
{
    public class OwnerDto
    {
        public Guid OwnerId { get; set; }
        public Guid UserId { get; set; }
        public Guid BusinessId { get; set; }
    }
}
