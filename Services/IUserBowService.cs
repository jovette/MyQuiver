using System;
using System.Collections.Generic;
using MyQuiver.Common;
using MyQuiver.DataAccess.Model;

namespace MyQuiver.Services
{
    public interface IUserBowService
    {
        ValueResponse<int> SaveUserBow(UserBow userBow);

        ValueResponse<UserBow> GetUserBow(int id);

        ValueResponse<List<UserBow>> GetUsersBows(int userId);
    }
}
