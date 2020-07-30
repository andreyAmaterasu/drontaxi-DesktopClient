using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class RoleForUser
    {
        public string Email { get; set; }
        public string Role { get; set; }

        public virtual Useraccount EmailNavigation { get; set; }
        public virtual AvailableRoles RoleNavigation { get; set; }
    }
}
