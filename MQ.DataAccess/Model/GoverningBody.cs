using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    /// <summary>
    /// An archery governing body which handles tournaments, olympic qualifiers, and archery development
    /// </summary>
    public class GoverningBody
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoverningBodyId { get; set; }

        /// <summary>
        /// Get or set the country in which the governing body belongs
        /// </summary>
        [Required]
        public Country Country { get; set; }

        /// <summary>
        /// Get or set the name of the governing body
        /// </summary>
        [Required, StringLength(64)]
        public string BodyName { get; set; }

        /// <summary>
        /// Get or set the address line of its headquarters
        /// </summary>
        public string HeadquartersAddressLine { get; set; }

        public string HeadquartersSecondAddressLine { get; set; }

        public string HeadquartersThirdAddressLine { get; set; }

        /// <summary>
        /// Get or set the city of its headquarters
        /// </summary>
        [Required, StringLength(32)]
        public string HeadquartersCity { get; set; }

        /// <summary>
        /// Get or set the state or province of the governing body
        /// </summary>
        public StateProvince StateProvince { get; set; }

        public string HeadquartersPostalCode { get; set; }

        public string Website { get; set; }

        [StringLength(512)]
        public string LogoPath { get; set; }

        /// <summary>
        /// Get or set whether this governing body has the authority to determine olympians
        /// </summary>
        [Required]
        public bool DeterminesOlympicQualifiers { get; set; }
    }
}
