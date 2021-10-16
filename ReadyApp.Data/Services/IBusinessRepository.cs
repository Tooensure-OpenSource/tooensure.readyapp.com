using ReadyApp.data.ResourceParameters;
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
        /// <summary>
        /// "There is a list of businesses", if you want to select a business, collect the object data
        /// then pass it into GetBusiness(1). Which will search for business with a id of 1.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Business GetBusiness(Guid id);
        /// <summary>
        /// When a user searches a username, wouldn't it be nice to have a list of business
        /// (Yes), but i believe returning a "list of business `.Usernames`", is better.
        /// Returning a full object, where object may have sensitive data like business finace.
        /// (Resoleved) Auto Mapper to map data tranfer objects.
        /// (Pending) private password and email, maybe even username;
        /// user construtors to set, methods to get.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Business> GetBusinesses();
        /// <summary>
        /// Search implemenatation for searching business by its username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        IEnumerable<Business> GetBusinesses(BusinessResorcesParameters businessResorces);
        bool BusinessExist(Business business);
        /// <summary>
        /// Check if a businesses in data store container username
        /// </summary>
        /// <param name="business"></param>
        /// <returns>true if there is in fact a business with username</returns>
        bool BusinessExistByUsername(string username);
        void RegisterBusiness(Business business);
        void Save();
    }
}
