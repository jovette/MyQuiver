using System.ComponentModel.DataAnnotations;

namespace MyQuiver.DataAccess.Model
{
    public class ArrowVane
    {
        public int ArrowVaneId { get; set; }

        [StringLength(64), Required]
        public string ModelName { get; set; }

        [StringLength(64), Required]
        public string ProductDescription { get; set; }

        [Range(1,10), Required]
        public double VaneLength { get; set; }

        [StringLength(512)]
        public string PhotographPath { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
