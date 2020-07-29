using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class Transport
    {
        public Transport()
        {
            AdditionalAttribute = new HashSet<AdditionalAttribute>();
            Maintenance = new HashSet<Maintenance>();
            OrderOfUser = new HashSet<OrderOfUser>();
            TransportComplectation = new HashSet<TransportComplectation>();
        }

        public int IdTransport { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public short YearOfProduction { get; set; }
        public string NumberOfRegistrtion { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public DateTime? WriteoffDate { get; set; }
        public string TransportStatus { get; set; }
        public int RepairCycle { get; set; }
        public int CycleOfTechnicalInspections { get; set; }

        public virtual СycleOfTechnicalInspections CycleOfTechnicalInspectionsNavigation { get; set; }
        public virtual RepairCycle RepairCycleNavigation { get; set; }
        public virtual TransportPhoto TransportPhoto { get; set; }
        public virtual ICollection<AdditionalAttribute> AdditionalAttribute { get; set; }
        public virtual ICollection<Maintenance> Maintenance { get; set; }
        public virtual ICollection<OrderOfUser> OrderOfUser { get; set; }
        public virtual ICollection<TransportComplectation> TransportComplectation { get; set; }
    }
}
