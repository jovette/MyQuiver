using MyQuiver.Common;
using MyQuiver.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuiver.DataAccess
{
    public interface ILimbRepository : IRepository<Limb, int>
    {
        /// <summary>
        /// Find limbs by the length of the limb
        /// </summary>
        /// <param name="length">The length of the limbs</param>
        /// <returns>List of limbs matching the given length</returns>
        List<Limb> FindByLimbLength(LimbLength length);

        /// <summary>
        /// Finds limbs by their material
        /// </summary>
        /// <param name="material">The material type of the limb</param>
        /// <returns>List of limbs matching the limb material</returns>
        List<Limb> FindByLimbMaterial(LimbMaterial material);

        /// <summary>
        /// Find limbs by draw weight
        /// </summary>
        /// <param name="drawWeight">The draw weight of the bow</param>
        /// <returns>Limbs matching the draw weight</returns>
        List<Limb> FindByDrawWeight(int drawWeight);
    }
}
