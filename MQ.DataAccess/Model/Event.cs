using System;
using System.ComponentModel.DataAnnotations;

namespace MyQuiver.DataAccess.Model
{
    public class Event
    {
        public int EventId { get; set; }

        /// <summary>
        /// Get or set the format of the event
        /// </summary>
        [Required]
        public EventFormat Format { get; set; }

        /// <summary>
        /// Get or set the governing body associated with this format
        /// </summary>
        [Required]
        public GoverningBody GoverningBody { get; set; }

        [Required, StringLength(32)]
        public string Name { get; set; }

        public DateTime EventStartDate { get; set; }

        public DateTime EventEndDate { get; set; }

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

        public string PrimaryContact { get; set; }

        public string EventWebsite { get; set; }

        public bool MajorEvent { get; set; }

        public bool NationalTeamQualifier { get; set; }

        public bool OlympicQualifier { get; set; }

        public double? TotalPurse { get; set; }
    }
}
