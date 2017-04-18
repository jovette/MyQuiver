using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiver.DataAccess.Model
{
    public class Organization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrganizationId { get; set; }

        /// <summary>
        /// Get or set the governing body this organization belongs
        /// </summary>
        [Required]
        public GoverningBody GoverningBody { get; set; }

        [Required, StringLength(32)]
        public string Name { get; set; }

        /// <summary>
        /// Get or set the address line of its 
        /// </summary>
        public string AddressLine { get; set; }

        public string SecondAddressLine { get; set; }

        public string ThirdAddressLine { get; set; }

        /// <summary>
        /// Get or set the city of its 
        /// </summary>
        [Required, StringLength(32)]
        public string City { get; set; }

        /// <summary>
        /// Get or set the state or province of the governing body
        /// </summary>
        public StateProvince StateProvince { get; set; }

        public string Website { get; set; }

        [StringLength(512)]
        public string LogoPath { get; set; }

        public bool MembershipRequired { get; set; }

        public string PostalCode { get; set; }
    }
}
