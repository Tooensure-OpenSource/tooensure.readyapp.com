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
        public Business GetBusiness(Guid id)
        {
            return _dataContext.Businesses.FirstOrDefault(b => b.BusinessId == id);
        }

        public IEnumerable<Business> GetBusinesses()
        {
            return _dataContext.Businesses.ToList();
        }
    }
}
