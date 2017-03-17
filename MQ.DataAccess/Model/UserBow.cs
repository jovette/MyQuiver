using MyQuiver.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    public class UserBow
    {
        /// <summary>
        /// Get or set the primary identifier of the bow
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserBowId { get; set; }

        /// <summary>
        /// Get or set the archer associated with this bow
        /// </summary>
        public User Archer { get; set; }

        /// <summary>
        /// Get or set the name of the bow
        /// </summary>
        public string BowName { get; set; }

        /// <summary>
        /// Get or set the type of bow used
        /// </summary>
        public BowType BowType { get; set; }

        /// <summary>
        /// The optimum draw length of the archer for this bow
        /// </summary>
        public double? DrawLength { get; set; }

        /// <summary>
        /// Get or set the amount of weight on each draw configured for this bow. Can be different than the manufacturer draw weight
        /// </summary>
        public double DrawWeight { get; set; }

        /// <summary>
        /// Get or set the riser part of the bow
        /// </summary>
        public Riser RiserPart { get; set; }

        /// <summary>
        /// Get or set the limbs of the bow if applicable
        /// </summary>
        public Limb LimbPart { get; set; }

        /// <summary>
        /// Get or set the arrow shaft
        /// </summary>
        public ArrowShaft Shaft { get; set; }

        /// <summary>
        /// Get or set the arrow point
        /// </summary>
        public ArrowPoint Point { get; set; }

        /// <summary>
        /// Get or set the vanes used on the arrow
        /// </summary>
        public ArrowVane Vane { get; set; }

        /// <summary>
        /// Get or set an enumerable list of additional parts of the bow such as the clicker or the peep hole
        /// </summary>
        public IEnumerable<BowPart> AdditionalParts { get; set; }
    }
}
