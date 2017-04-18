using MyQuiver.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuiver.DataAccess
{
    public interface IRiserRepository : IRepository<Riser, int>
    {
        /// <summary>
        /// Find risers by the exact length
        /// </summary>
        /// <param name="riserLength"></param>
        /// <returns>List of risers matching length</returns>
        List<Riser> FindByLength(int riserLength);

        /// <summary>
        /// Find risers by the model of the riser
        /// </summary>
        /// <param name="modelName">Name of the riser model</param>
        /// <returns>List of risers matching model</returns>
        List<Riser> FindByModel(string modelName);

        /// <summary>
        /// Find risers by the manufactuer
        /// </summary>
        /// <param name="manufacturer">Name of the riser manufacturer</param>
        /// <returns>List of risers matching manufacturer</returns>
        List<Riser> FindByManufacturer(string manufacturer);

        /// <summary>
        /// Find risers by material type
        /// </summary>
        /// <param name="materialType">Type of material the riser comprises</param>
        /// <returns>List of risers matching material</returns>
        List<Riser> FindByRiserMaterialType(string materialType);
    }
}
