using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class TransportPhoto
    {
        public int Transport { get; set; }
        public string Photo { get; set; }

        public virtual Transport TransportNavigation { get; set; }
    }
}
