using ReadyApp.Data;
using ReadyApp.Data.Services;
using ReadyApp.Domain;

namespace ReadyApp.Api.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DataContext _dataContext;

        public OwnerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        ///
        public Owner GetOwner(Guid ownerId)
        {
            return _dataContext.Owners.Find(ownerId);
        }

        public Owner GetOwnerOfUser(Guid userId)
        {
            return _dataContext.Owners.FirstOrDefault(o => o.UserId == userId);
        }

        public IEnumerable<Owner> GetOwners()
        {
            return _dataContext.Owners.ToList();
        }

        public IEnumerable<Owner> GetOwnersForBusiness(Guid businessId)
        {
            return _dataContext.Owners.Where(o => o.BusinessId == businessId);
        }

        public bool OwnerExists(Guid ownerId)
        {
            return _dataContext.Owners.Any();
        }


        public bool UserExists(Guid userId)
        {
            return _dataContext.Users.Any(u => u.UserId == userId);
        }
    }
}
