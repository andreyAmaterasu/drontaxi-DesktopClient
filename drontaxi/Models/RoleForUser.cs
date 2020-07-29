using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class RoleForUser
    {
        public RoleForUser()
        {
            SystemFunction = new HashSet<SystemFunction>();
        }

        public string SystemName { get; set; }
        public string RoleName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Email { get; set; }

        public virtual Useraccount EmailNavigation { get; set; }
        public virtual ICollection<SystemFunction> SystemFunction { get; set; }
    }
}
