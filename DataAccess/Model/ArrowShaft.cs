using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    public class ArrowShaft
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArrowShaftId { get; set; }

        public int ManufacturerId { get; set; }

        [StringLength(24), Required]
        public string ArrowMaterialType { get; set; }

        /// <summary>
        /// Get or set the length of the shaft the manufacturer produces
        /// 
        /// Valid values are 1-100 cm
        /// </summary>
        [Range(1,100)]
        public double ManufacturedShaftLength { get; set; }

        [StringLength(48), Required]
        public string ModelName { get; set; }

        [StringLength(1024), Required]
        public string ShaftDescription { get; set; }

        [StringLength(512)]
        public string PhotographPath { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
