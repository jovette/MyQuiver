using MyQuiver.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuiver.DataAccess.Filters
{
    public sealed class LimbFilter : ComponentFilter
    {
        public int? LimbId { get; set; }

        public LimbMaterial? LimbMaterialType { get; set; }

        public LimbLength? LimbLengthType { get; set; }

        public int? DrawWeight { get; set; }
    }
}
