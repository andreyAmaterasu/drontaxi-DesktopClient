using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class Useraccount
    {
        public Useraccount()
        {
            OrderOfUserCustomerNavigation = new HashSet<OrderOfUser>();
            OrderOfUserOperatorNavigation = new HashSet<OrderOfUser>();
            RoleForUser = new HashSet<RoleForUser>();
            SaveUseraccount = new HashSet<SaveUseraccount>();
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<OrderOfUser> OrderOfUserCustomerNavigation { get; set; }
        public virtual ICollection<OrderOfUser> OrderOfUserOperatorNavigation { get; set; }
        public virtual ICollection<RoleForUser> RoleForUser { get; set; }
        public virtual ICollection<SaveUseraccount> SaveUseraccount { get; set; }
    }
}
