using drontaxi.ViewModels;
using System;
using System.Collections.Generic;

namespace drontaxi.Models
{
    public partial class RoleForUser :BaseViewModel
    {
        private string systemName;
        private string email;
        private string roleName;
        private DateTime startDate;
        private DateTime? expirationDate;

        public string SystemName { 
            get { return systemName; }
            set {
                systemName = value;
                OnPropertyChanged("SystemName");
            }
        }
        public string Email { 
            get { return email; }
            set {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public string RoleName { 
            get { return roleName; }
            set {
                roleName = value;
                OnPropertyChanged("RoleName");
            }
        }
        public DateTime StartDate { 
            get { return startDate; }
            set {
                startDate = value;
                OnPropertyChanged("StartDate");
            }
        }
        public DateTime? ExpirationDate { 
            get { return expirationDate; }
            set {
                expirationDate = value;
                OnPropertyChanged("ExpirationDate");
            }
        }

        //public string SystemName { get; set; }
        //public string Email { get; set; }
        //public string RoleName { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime? ExpirationDate { get; set; }

        public virtual Useraccount EmailNavigation { get; set; }
    }
}
