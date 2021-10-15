using ReadyApp.Domain;
using ReadyApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data.Services
{
    /// <summary>
    /// Interface for getting list of owner, then filtering to the user, business owners etc.
    /// </summary>
    public interface IOwnerRepository
    {
        // Local scope of business
        /// <summary>
        /// Get owner that have id param
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        Owner GetOwner(Guid ownerId);
        /// <summary>
        /// Retrieve owner of specfic user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A owner with has user data</returns>
        Owner GetOwnerOfUser(Guid userId);
        /// <summary>
        /// Return IEnumerable of owners of specific business. 
        /// </summary>
        /// <param name="businessId"></param>
        /// <returns>Owners of specific business id prarm</returns>
        IEnumerable<Owner> GetOwnersForBusiness(Guid businessId);

        // Global scope of business
        /// <summary>
        /// Get a Enumerable of owners, stored in Db store/context
        /// </summary>
        /// <returns>list of owners</returns>
        IEnumerable<Owner> GetOwners();
        /// <summary>
        /// See if there is in a user of object
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        bool OwnerExists(Guid businessId);
        void AddOwner(Guid userId,Guid businessId);
    }
}
