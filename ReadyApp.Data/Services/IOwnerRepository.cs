using ReadyApp.Domain;
using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Services
{
    public interface IOwnerRepository
    {
        // Local scope of business
        Owner GetOwner(Guid ownerId);
        Owner GetOwnerOfUser(Guid userId);
        IEnumerable<Owner> GetOwnersForBusiness(Guid businessId);

        // Global scope of business
        IEnumerable<Owner> GetOwners();
        bool OwnerExists(Guid ownerId);
    }
}
