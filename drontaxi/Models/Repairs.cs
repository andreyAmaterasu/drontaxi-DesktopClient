using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class Repairs
    {
        public int IdRepairs { get; set; }
        public string TypeOfRepairs { get; set; }
        public DateTime DateOfRepairs { get; set; }
        public string NatureOfFailure { get; set; }
        public int Master { get; set; }
        public int Unit { get; set; }

        public virtual Master MasterNavigation { get; set; }
        public virtual TransportComplectation UnitNavigation { get; set; }
    }
}
