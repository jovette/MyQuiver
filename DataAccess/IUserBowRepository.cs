using MyQuiver.Common;
using MyQuiver.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuiver.DataAccess
{
    public interface IUserBowRepository : IRepository<UserBow, int>
    {
        /// <summary>
        /// Finds all bows belonging to a user
        /// </summary>
        /// <param name="user">The user to find all bows</param>
        /// <returns>List of bows matching the user</returns>
        List<UserBow> FindByUser(User user);

        /// <summary>
        /// Finds all of a user's bow according to type such as recurve or compound
        /// </summary>
        /// <param name="user">The user to find all bows</param>
        /// <param name="bowType">The type of bow desired</param>
        /// <returns>List of bows matching the type and user</returns>
        List<UserBow> FindByUserAndType(User user, BowType bowType);
    }
}
