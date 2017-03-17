using System.Collections.Generic;
using MyQuiver.DataAccess.Model;

namespace MyQuiver.DataAccess
{
    /// <summary>
    /// Provides access to components of archery equipment from the data store
    /// </summary>
    public interface IComponentAccess
    {
        #region Arrow Point
        int CreateArrowPoint(ArrowPoint point);

        List<ArrowPoint> GetArrowPoints(Filter filter);

        int UpdateArrowPoint(ArrowPoint point);

        int DeleteArrowPoint(int id);
        #endregion Arrow Point

        #region Arrow Shaft
        int CreateArrowShaft(ArrowShaft shaft);

        List<ArrowShaft> GetArrowShafts(Filter filter);

        int UpdateArrowShaft(ArrowShaft shaft);

        int DeleteArrowShaft(int id);
        #endregion Arrow Shaft
    }
}
