using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Services
{
    public interface IBusinessRepository
    {
        Business GetBusiness(Guid id);
        IEnumerable<Business> GetBusinesses();
    }
}
