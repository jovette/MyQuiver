using System.ComponentModel.DataAnnotations;

namespace MyQuiver.DataAccess.Model
{
    /// <summary>
    /// A sovereign, self-governing, nation-state on Earth
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Get or set the ID of the country, use the UN country ID designation for this value
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Get or set the ISO country code
        /// </summary>
        [StringLength(2), Required]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// Get or set the United Nations country code
        /// </summary>
        [StringLength(3), Required]
        public string UnCountryCode { get; set; }

        /// <summary>
        /// Get or set the name of the country
        /// </summary>
        [StringLength(32), Required]
        public string Name { get; set; }
    }
}
