using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    public class Riser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RiserId { get; set; }

        public int ManufacturerId { get; set; }

        [StringLength(32), Required]
        public string ModelName { get; set; }

        public int RiserLength { get; set; }

        [StringLength(16), Required]
        public string RiserMaterialType { get; set; }

        [StringLength(1024), Required]
        public string RiserDescription { get; set; }

        [StringLength(512)]
        public string RiserPhotographPath { get; set; }

        public Manufacturer Manfacturer { get; set; }
    }
}
