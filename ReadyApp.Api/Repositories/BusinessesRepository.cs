using ReadyApp.data.ResourceParameters;
using ReadyApp.Data;
using ReadyApp.Data.Services;
using ReadyApp.Domain.Entity;

namespace ReadyApp.Api.Repositories
{
    public class BusinessesRepository : IBusinessRepository
    {
        private readonly DataContext _dataContext;

        public BusinessesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool BusinessExistByUsername(string username)
        {
            return _dataContext.Businesses.Any(b => b.Username == username);
        }
        public bool BusinessExist(Business business)
        {
            return _dataContext.Businesses.Any(b => b.Username == business.Username);
        }

        public Business GetBusiness(Guid id)
        {
            return _dataContext.Businesses.FirstOrDefault(b => b.BusinessId == id);
        }

        public IEnumerable<Business> GetBusinesses()
        {
            return _dataContext.Businesses.ToList();
        }

        public IEnumerable<Business> GetBusinesses(BusinessResorcesParameters businessResorces)
        {
            if (string.IsNullOrWhiteSpace(businessResorces.Username) && string.IsNullOrWhiteSpace(businessResorces.SearchQuery))
            {
                return GetBusinesses();
            }
            var collection = _dataContext.Businesses as IQueryable<Business>; 

            if (!string.IsNullOrWhiteSpace(businessResorces.Username))
            {
                businessResorces.Username = businessResorces.Username.Trim();
                return _dataContext.Businesses.Where(s => s.Username == businessResorces.Username);
            }

            if (!string.IsNullOrWhiteSpace(businessResorces.SearchQuery))
            {
                businessResorces.SearchQuery = businessResorces.SearchQuery.Trim();
                return _dataContext.Businesses.Where(
                    s => s.Username.Contains(businessResorces.SearchQuery));
            }

            return collection.ToList();
        }

        public void RegisterBusiness(Business business)
        {
            _dataContext.Businesses.Add(business);
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
