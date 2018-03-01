using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyOwnerLib
{
    public class Heating
    {
        public string HeatingCode { get; set; }
        public string HeatingType { get; set; }

        public ICollection<PropertyDetails> Properties { get; set; }
    }
}
