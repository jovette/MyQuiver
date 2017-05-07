using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyQuiver.DataAccess.Filters
{
    public sealed class RiserFilter : ComponentFilter
    {
        public int? RiserId { get; set; }

        public int? RiserLength { get; set; }

        [StringLength(32)]
        public string ModelName { get; set; }

        [StringLength(16)]
        public string RiserMaterialType { get; set; }
    }
}
