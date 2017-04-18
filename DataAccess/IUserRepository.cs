using System;
using System.Collections.Generic;
using System.Text;
using MyQuiver.DataAccess.Model;
using MyQuiver.DataAccess.Filters;

namespace MyQuiver.DataAccess
{
    public interface IUserRepository : IRepository<User, int>
    {
        /// <summary>
        /// Get a user by e-mail
        /// </summary>
        /// <param name="emailAddress">The e-mail address of the user</param>
        /// <returns>The user matching the e-mail address or null if not found</returns>
        User GetByEmail(string emailAddress);

        /// <summary>
        /// Find users by filter criteria
        /// </summary>
        /// <param name="filter">Filter parameters</param>
        /// <returns>List of users matching the filter</returns>
        List<User> FindUsers(UserFilter filter);
    }
}
