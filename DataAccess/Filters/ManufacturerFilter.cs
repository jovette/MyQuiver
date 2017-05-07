using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyQuiver.DataAccess.Filters
{
    public sealed class ManufacturerFilter
    {
        public int? ManufacturerId { get; set; }

        [StringLength(24)]
        public string Name { get; set; }

        [StringLength(24),]
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
    }
}
