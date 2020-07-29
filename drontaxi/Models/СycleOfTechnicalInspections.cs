using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class СycleOfTechnicalInspections
    {
        public СycleOfTechnicalInspections()
        {
            Transport = new HashSet<Transport>();
        }

        public int IdTechnicalInspections { get; set; }
        public string PeriodicityType { get; set; }
        public string PeriodicityValue { get; set; }

        public virtual ICollection<Transport> Transport { get; set; }
    }
}
