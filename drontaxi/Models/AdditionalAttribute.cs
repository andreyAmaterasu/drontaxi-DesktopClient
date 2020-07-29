using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class AdditionalAttribute
    {
        public int IdAttribute { get; set; }
        public string Attribute { get; set; }
        public string AttributeValue { get; set; }
        public int Transport { get; set; }

        public virtual Transport TransportNavigation { get; set; }
    }
}
