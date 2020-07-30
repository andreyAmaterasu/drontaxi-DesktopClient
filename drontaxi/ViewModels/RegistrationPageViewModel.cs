using drontaxi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drontaxi.ViewModels
{
    class RegistrationPageViewModel : BaseViewModel
    {
        private Useraccount createdUseraccount;
        public Useraccount CreatedUseraccount {
            get { return createdUseraccount; }
            set {
                createdUseraccount = value;
                OnPropertyChanged("CreatedUseraccount");
            }
        }
    }
}
