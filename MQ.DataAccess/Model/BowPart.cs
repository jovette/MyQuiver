using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    /// <summary>
    /// A generic part of a bow such as a plunger, a rest, or a button
    /// </summary>
    public class BowPart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BowPartId { get; set; }

        public int ManufacturerId { get; set; }

        [StringLength(32), Required]
        public string PartName { get; set; }

        [StringLength(1024), Required]
        public string PartDescription { get; set; }

        [StringLength(512)]
        public string PartPhotographPath { get; set; }
    }
}
