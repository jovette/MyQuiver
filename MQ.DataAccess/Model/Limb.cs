using MyQuiver.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    public class Limb
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LimbId { get; set; }

        [StringLength(32), Required]
        public LimbLength LimbLengthType { get; set; }

        [StringLength(32), Required]
        public LimbMaterial LimbMaterialType { get; set; }

        /// <summary>
        /// Get or set the draw weight as set by the manufacturer
        /// </summary>
        [Range(1,80)]
        public int DrawWeight { get; set; }

        /// <summary>
        /// Get or set the path to the photograph of the limb
        /// </summary>
        public string LimbPhotographPath { get; set; }

        /// <summary>
        /// Get or set the limb's manufacturer
        /// </summary>
        public Manufacturer Manufacturer { get; set; }
    }
}
