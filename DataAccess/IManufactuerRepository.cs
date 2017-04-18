using MyQuiver.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuiver.DataAccess
{
    public interface IManufactuerRepository : IRepository<Manufacturer, int>
    {
        /// <summary>
        /// Find a manufacturer by its name.
        /// </summary>
        /// <param name="manufacturerName">The complete or partial match of the manufactuer. If partial, searches the beginning of the name</param>
        /// <returns>List of manufacturers that match the name</returns>
        List<Manufacturer> FindByName(string manufacturerName);
    }
}
