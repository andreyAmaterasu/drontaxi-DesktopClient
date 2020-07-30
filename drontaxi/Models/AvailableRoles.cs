using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class AvailableRoles
    {
        public AvailableRoles()
        {
            RoleForUser = new HashSet<RoleForUser>();
            SystemFunction = new HashSet<SystemFunction>();
        }

        public string SystemName { get; set; }
        public string RoleName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public virtual ICollection<RoleForUser> RoleForUser { get; set; }
        public virtual ICollection<SystemFunction> SystemFunction { get; set; }
    }
}
