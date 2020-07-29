using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class SaveUseraccount
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public virtual Useraccount EmailNavigation { get; set; }
    }
}
