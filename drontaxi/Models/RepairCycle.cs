using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class RepairCycle
    {
        public RepairCycle()
        {
            Transport = new HashSet<Transport>();
        }

        public int IdRepairCycle { get; set; }
        public string PeriodicityType { get; set; }
        public short PeriodicityValue { get; set; }

        public virtual ICollection<Transport> Transport { get; set; }
    }
}
