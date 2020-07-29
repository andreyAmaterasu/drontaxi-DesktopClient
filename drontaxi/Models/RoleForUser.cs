using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class RoleForUser
    {
        public string SystemName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public virtual Useraccount EmailNavigation { get; set; }
    }
}
