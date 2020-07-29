using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class OrderOfUser
    {
        public int NumberOfOrder { get; set; }
        public DateTime DatetimeOfOrder { get; set; }
        public string Customer { get; set; }
        public string DeparturePointAddress { get; set; }
        public string DestinationAddress { get; set; }
        public string Status { get; set; }
        public int Transport { get; set; }
        public string Operator { get; set; }

        public virtual Useraccount CustomerNavigation { get; set; }
        public virtual Useraccount OperatorNavigation { get; set; }
        public virtual Transport TransportNavigation { get; set; }
    }
}
