using ReadyApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyApp.Data
{
    internal interface IUserData
    {
        /// <summary>
        /// All users must sign in, before interacton between one another 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        User CreateUser(User user);
        /// <summary>
        /// Update a existaning user creditentials such as password, email, username
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        User UpdateUser(User user);
        /// <summary>
        /// May be usaful to get a specific user by their by a uniqe id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A user of the given id prarm</returns>
        User UserById(int id);
        /// <summary>
        /// It's can act as a click event also, when working with UI displaying.
        /// Anyways, Your going to want to get a sigle object of business.
        /// </summary>
        /// <param name="id">Unque identitfier</param>
        /// <returns>A business of the given id prarm</returns>
        Business BusinessById(int id);
        /// <summary>
        /// Since there can be a list of businesses, then here's away to interate over
        /// the list of businesses.
        /// </summary>
        /// <param name="businesses"></param>
        /// <returns>A list of business</returns>
        List<Business> ListOfBusinesses(List<Business> businesses);

    }
}
