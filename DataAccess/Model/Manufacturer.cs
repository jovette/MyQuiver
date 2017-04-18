using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    public class Manufacturer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManufacturerId { get; set; }

        [StringLength(24),Required]
        public string Name { get; set; }

        [StringLength(128), Required]
        public string AddressLine { get; set; }

        [StringLength(128)]
        public string SecondAddressLine { get; set; }

        [StringLength(128)]
        public string ThirdAddressLine { get; set; }

        [StringLength(24), Required]
        public string City { get; set; }

        [StringLength(24)]
        public string StateProvince { get; set; }

        [StringLength(8)]
        public string PostalCode { get; set; }

        [StringLength(3)]
        public string CountryCode { get; set; }

        [StringLength(256), Required]
        public string Website { get; set; }

        [StringLength(256)]
        public string ContactTelephone { get; set; }

        [StringLength(256), Required]
        public string PrimaryManfacturerLogoPath { get; set; }

        [StringLength(256)]
        public string AlternateManufacturerLogoPath { get; set; }

        public IEnumerable<Riser> Risers { get; set; }

        public IEnumerable<Limb> Limbs { get; set; }

        public IEnumerable<BowPart> BowParts { get; set; }

        public IEnumerable<ArrowShaft> ArrowShafts { get; set; }

        public IEnumerable<ArrowPoint> ArrowPoints { get; set; }
    }
}
