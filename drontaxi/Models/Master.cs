using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class Master
    {
        public Master()
        {
            Maintenance = new HashSet<Maintenance>();
            Repairs = new HashSet<Repairs>();
        }

        public int IdMaster { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<Maintenance> Maintenance { get; set; }
        public virtual ICollection<Repairs> Repairs { get; set; }
    }
}
