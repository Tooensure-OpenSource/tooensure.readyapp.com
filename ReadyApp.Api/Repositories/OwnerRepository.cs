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

        public void CreateOwner(Guid businessId, Owner owner)
        {
            owner.BusinessId = businessId;
            _dataContext.Owners.Add(owner);
        }



        ///
        public Owner GetOwner(Guid ownerId)
        {
            return _dataContext.Owners.Find(ownerId);
        }

        public Owner GetOwnerForBusiness(Guid userId, Guid businessId)
        {
            return new Owner(userId, businessId);
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

        public bool OwnerExistForBusiness(Guid businessId, Guid userId)
        {
            return _dataContext.Owners.Any(o => o.BusinessId == businessId && o.UserId == userId);
        }

        public bool OwnerExists(Guid owerId)
        {
            return _dataContext.Owners.Any(o => o.OwnerId == owerId);
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
