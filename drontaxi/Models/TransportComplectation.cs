using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class TransportComplectation
    {
        public TransportComplectation()
        {
            Repairs = new HashSet<Repairs>();
        }

        public int IdUnit { get; set; }
        public string UnitName { get; set; }
        public int Transport { get; set; }

        public virtual Transport TransportNavigation { get; set; }
        public virtual ICollection<Repairs> Repairs { get; set; }
    }
}
