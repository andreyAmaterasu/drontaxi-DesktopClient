using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class Maintenance
    {
        public int IdMaintenance { get; set; }
        public DateTime DateOfMaintenance { get; set; }
        public string InspectionResult { get; set; }
        public int Master { get; set; }
        public int Transport { get; set; }

        public virtual Master MasterNavigation { get; set; }
        public virtual Transport TransportNavigation { get; set; }
    }
}
