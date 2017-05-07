using System;
using System.Collections.Generic;
using System.Text;

using MyQuiver.Common;
using MyQuiver.DataAccess.Model;

namespace MyQuiver.Services
{
    public interface IArrowService
    {
        ValueResponse<int> SaveArrow(ArrowPoint point, ArrowShaft shaft, ArrowVane vane);

        ValueResponse<int> DeleteArrow(ArrowPoint point, ArrowShaft shaft, ArrowVane vane);

        ValueResponse<int> SaveArrowShaft(ArrowShaft shaft);

        ValueResponse<int> SaveArrowPoint(ArrowPoint point);

        ValueResponse<int> SaveArrowVane(ArrowVane vane);
    }
}
