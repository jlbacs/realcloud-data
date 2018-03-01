﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RealCloud.Data
{
    public class RoofType
    {
        public string RoofTypeCode { get; set; }
        public string RoofTypeDescription { get; set; }

        public virtual ICollection<PropertyDetails> Properties { get; set; }
    }
}
