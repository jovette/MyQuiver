using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    public class ArrowPoint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArrowPointId { get; set; }

        public int ManufacturerId { get; set; }

        [StringLength(24), Required]
        public string PointType { get; set; }

        [StringLength(24), Required]
        public string PointAttachType { get; set; }

        /// <summary>
        /// Get or set the weight of the point in grains. Valid values are 0-200 gr
        /// </summary>
        [Range(0,200)]
        public int PointWeight { get; set; }

        [StringLength(48), Required]
        public string ModelName { get; set; }

        [StringLength(1024)]
        public string PointDescription { get; set; }

        [StringLength(512)]
        public string PhotographPath { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
