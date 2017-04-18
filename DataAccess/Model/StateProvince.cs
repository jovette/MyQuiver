using System.ComponentModel.DataAnnotations;

namespace MyQuiver.DataAccess.Model
{
    /// <summary>
    /// A geopolitical subdivision of a sovereign nation-state
    /// </summary>
    public class StateProvince
    {
        public int StateProvinceId { get; set; }

        /// <summary>
        /// Get or set the abbreviation of the state or province if applicable
        /// </summary>
        [StringLength(4)]
        public string Abbreviation { get; set; }

        [StringLength(32), Required]
        public string Name { get; set; }

        /// <summary>
        /// Get or set the country that the state or province belongs
        /// </summary>
        [Required]
        public Country ParentCountry { get; set; }
    }
}
