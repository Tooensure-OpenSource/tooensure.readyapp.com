using ReadyApp.Api.Models.Referance;
using System.ComponentModel.DataAnnotations;

namespace ReadyApp.Api.Models.Creation
{
    public class BusinessCreationDto
    {
        [Required] public string Name { get; set; }
        [Required] public string Username { get; set; }
        [Required] public OwnerReferanceDto DefaultOwner { get; set; } = new OwnerReferanceDto();
        public ICollection<OwnerReferanceDto> Owners { get; private set; } = new List<OwnerReferanceDto>();

        public BusinessCreationDto()
        {
            Owners.Add(DefaultOwner);
        }
    }
}
